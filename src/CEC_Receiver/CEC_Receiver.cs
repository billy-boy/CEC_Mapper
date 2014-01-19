using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CecSharp;

namespace billy_boy.CEC_Receiver
{
    public class CEC_Receiver : CecCallbackMethods
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private int _logLevel = (int)CecLogLevel.All;
        private LibCecSharp _lib;
        private LibCECConfiguration _config;
        private bool _connected = false;
        private String _port = "";

        /// <summary>
        /// Inititalise receiver class and configuration for communication with CEC adapter via libCEC. Does not conenct, use Start() for this.
        /// </summary>
        public CEC_Receiver()
        {
            Init();
        }

        ~CEC_Receiver()
        {
            DeInit();
        }

        #region Creation & Destroy

        private void Init()
        {
            _connected = false;
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                if (_config == null)
                    _config = new LibCECConfiguration();

                _config.SetCallbacks(this);
                _config.DeviceTypes.Types[0] = CEC_Config.DeviceType;
                _config.DeviceName = CEC_Config.DeviceName;
                _config.ClientVersion = CEC_Config.CEC_ClientVersion;

                _config.WakeDevices.Clear();
                _config.PowerOffDevices.Clear();
                _config.PhysicalAddress = 0;
                _config.ActivateSource = false;

                if (CEC_Config.CEC_Vendor != CecVendorId.Unknown)
                    _config.TvVendor = CEC_Config.CEC_Vendor;

                _config.HDMIPort = CEC_Config.HDMI_Port;
                _config.BaseDevice = CEC_Config.CEC_BaseDevice;
                _config.AutodetectAddress = true;

                _logLevel = (int)CEC_Config.CEC_LogLevel;

                if (log.IsDebugEnabled) log.Debug("CEC configuration loaded.");

                if (_lib == null)
                {
                    _lib = new LibCecSharp(_config);
                    //_lib.InitVideoStandalone();
                    if (log.IsDebugEnabled) log.Debug("libCEC initialised.");
                    if (log.IsDebugEnabled) log.Debug("Autodetected HDMI port: " + _config.AutodetectAddress.ToString());
                }
                else
                {
                    _lib.SetConfiguration(_config);                  
                    if (log.IsDebugEnabled) log.Debug("libCEC config updated.");
                }
                //Enabling the callbacks
                _lib.EnableCallbacks(this);
            }
            catch (Exception ex)
            {
                if (log.IsDebugEnabled) log.Debug("Could not configure libCEC." + ex.ToString());
                throw;
            }

        }

        private void DeInit()
        {
            if (_lib != null)
            {
                _lib.DisableCallbacks();
                _lib.Close();
                _lib.Dispose();
            }

            _port = "";
            _connected = false;

            _lib = null;
            _config = null;
        }

        /// <summary>
        /// Start the receiver with (re)initialisation of config and (re)connecting to the adapter.
        /// </summary>
        /// <returns>True if adapter is connected</returns>
        public bool Start()
        {
            Init();
            if (!Connect(CEC_Config.ConnectionTimeout)) return false;
            return true;
        }

        /// <summary>
        /// Disconnects from adapter and do disposing and cleanup.
        /// </summary>
        public void Stop()
        {
            DeInit();
        }

        #endregion

        #region Adapter events

        public override int ReceiveCommand(CecCommand command)
        {
            if (command.Opcode == CecSharp.CecOpcode.UserControlRelease)
            {
                if (log.IsDebugEnabled) log.Debug("HDMI CEC command: user control released.");               
            }
            else if (command.Opcode == CecSharp.CecOpcode.UserControlPressed)
            {
                if (log.IsDebugEnabled) log.Debug("HDMI CEC command: user control pressed.");               
            }
            // If the operator mode is Play/DeckControl
            else if ((command.Opcode == CecOpcode.Play || command.Opcode == CecOpcode.DeckControl)
                && command.Initiator == CecLogicalAddress.Tv && command.Parameters.Size == 1)
            {
                if (command.Opcode == CecOpcode.Play)
                {
                    if (command.Parameters.Data[0] == 0x24)
                    {
                        //KeyPress((int)CecUserControlCode.Play);
                    }
                    else if (command.Parameters.Data[0] == 0x25)
                    {
                        //KeyPress((int)CecUserControlCode.Pause);
                    }
                    else
                    {
                        //KeyPress((int)CecUserControlCode.Pause);
                    }
                }
                else
                {
                    //KeyPress((int)CecUserControlCode.Stop);
                }
            }
            else if (command.Opcode == CecOpcode.Standby)
            {
                if (log.IsDebugEnabled) log.Debug("HDMI CEC command: Device ["+command.Initiator.ToString()+"] standby.");
                if (command.Initiator == CecLogicalAddress.Tv)
                {
                    if (log.IsInfoEnabled) log.Info("HDMI CEC command: TV standby.");
                }
                //Raise an own event
                if (OnStandby != null)
                {
                    OnStandby(this, new CEC_StandbyEventArgs { Device = command.Initiator });
                }
                //KeyPress of -> KeyCode = (Int32)CecUserControlCode.PowerOffFunction
            }
            else if (command.Opcode == CecOpcode.ReportPowerStatus && command.Parameters.Size > 0)
            {
                if (log.IsDebugEnabled) log.Debug("HDMI CEC command: power status changed event. Device: [" + command.Initiator.ToString() + "] Status: [" + command.Parameters.Data[0].ToString()+ "]");
                //Raise an own event
                if (OnPowerStateChanged != null)
                {
                    OnPowerStateChanged(this, new CEC_PowerStatusChangedEventArgs { Device = command.Initiator, PowerStatus = command.Parameters.Data[0] });
                }
                //Wake up or standby specified devices (0x00 = On, 0x01 = Standby, 0x02 = Standby->On, 0x03 = On->Standby)
                //if (command.Initiator == CecLogicalAddress.Tv && (command.Parameters.Data[0] == 0x01 || command.Parameters.Data[0] == 0x03))
                //    standbyOtherDevices();
                //else if (command.Initiator == CecLogicalAddress.Tv && (command.Parameters.Data[0] == 0x00 ||command.Parameters.Data[0] == 0x02))
                //    wakeUpOtherDevices();
            }


            #region Debug logging

            string opcode = String.Empty;
            string param = String.Empty;

            if (command.OpcodeSet)
            {
                opcode = command.Opcode.ToString() + " (" + ((Int32)command.Opcode).ToString()+")";
            }
            else
                opcode = "POLL (no opcode set)";

            for (short i = 0; i < command.Parameters.Size; i++)
            {
                param += String.Format("{0:X}", command.Parameters.Data[i]);
            }

            string msg = "HDMI CEC command: [" + opcode + "] from: ["+command.Initiator.ToString()+"] to: ["+command.Destination.ToString()+"]";

            if (param.Length > 0)
            {
                msg += " parameters: [" + param+"]";
            }

            msg += "ACK? [" + command.Ack + "] EOM? [" + command.Eom.ToString() + "]";

            if (log.IsDebugEnabled) log.Debug(msg);

            #endregion

            return 1;
        }

        public override int ReceiveKeypress(CecKeypress key)
        {
            int keyCode = (int)key.Keycode;
            if (log.IsDebugEnabled) log.Debug(String.Format("HDMI CEC key press event: Button: [{0}] Code: [{1}] Duration: [{2}]", key.Keycode.ToString(), keyCode, key.Duration));

            //Raise an own event
            if (OnKeyPress != null && !key.Empty)
            {
                bool keyDown = false;
                if (key.Duration <= 0) keyDown = true;
                OnKeyPress(this, new CEC_KeyPressEventArgs { KeyCode = (Int32)key.Keycode, KeyDown = keyDown });
            }
            return 1;
        }

        public override int ReceiveLogMessage(CecLogMessage message)
        {
            if (((int)message.Level & LogLevel) == (int)message.Level)
            {
                if (log.IsDebugEnabled) log.Debug("CEC-Log: ["+message.Level.ToString()+"] "+message.Time.ToString() + "   "+message.Message);
            }
            return 1;
        }

        public override void SourceActivated(CecLogicalAddress address, bool activated)
        {
            if (log.IsDebugEnabled) log.Debug("HDMI-device: " + address.ToString() + " was " + (activated ? "activated." : "deactivated."));

            if (address == _lib.GetLogicalAddresses().Primary)
            {
                if (log.IsInfoEnabled) log.Info("This HDMI device [" + address.ToString() + "] has been " + (activated ? "activated." : "deactivated."));
                //Raise an own event
                if (OnSourceActivated != null)
                {
                    OnSourceActivated(this, new CEC_SourceActivatedEventArgs { Activated = activated });
                }
            }     
        }

        public override int ReceiveMenuStateChange(CecMenuState menuState)
        {
            if (log.IsDebugEnabled) log.Debug("CEC-MenuState: " + menuState.ToString());
            return 1;
        }

        public override int ReceiveAlert(CecAlert alert, CecParameter data)
        {
            if (log.IsDebugEnabled) log.Debug("Received libCEC alert: " + alert.ToString() + " - Type: [" + data.Type.ToString() + "] Data: [" + data.Data.ToString() + "]");
            return 1;
        }

        public override int ConfigurationChanged(LibCECConfiguration config)
        {
            _config = config;
            if (log.IsDebugEnabled) log.Debug("Configuration updated from libCEC.");
            if (log.IsDebugEnabled) log.Debug("Autodetected HDMI port: " + _config.AutodetectAddress.ToString());

            return 1;
        }

        #endregion

        #region Adapter communication

        public bool Connect(int timeout)
        {
            if (log.IsDebugEnabled) log.Debug("Opening connection to CEC-Adapter...");

            if (_lib == null)
            {
                if (log.IsErrorEnabled) log.Error("Unable to connect, library (libCEC) doesn't exist!");
                return false;
            }

            CecAdapter[] adapters = _lib.FindAdapters(string.Empty);
            if (adapters.Length > 0)
                return Connect(adapters[0].ComPort, timeout);
            else
            {
                if (log.IsErrorEnabled) log.Error("Unable to find free adapter. Adapter not connected or in use by other process?");
                return false;
            }
        }

        public bool Connect(string port, int timeout)
        {
            _connected = _lib.Open(port, timeout);
            if (_connected)
            {
                _port = port;
                if (log.IsInfoEnabled) log.Info("Connected succesfully to CEC-adapter on port: [" + port+"].");
                if (log.IsDebugEnabled) log.Debug("TV vendor: [" + _lib.GetDeviceVendorId(CecLogicalAddress.Tv).ToString()+"]");
                if (log.IsDebugEnabled) log.Debug("AVR connected: [" + _lib.IsActiveDevice(CecLogicalAddress.AudioSystem).ToString() + "] vendor: ["
                  + _lib.GetDeviceVendorId(CecLogicalAddress.AudioSystem)+"]");
                //Re-Enable the callbacks
                _lib.EnableCallbacks(this);

            }
            else
            {
                if (log.IsErrorEnabled) log.Error("Connection to adapter on port: [" + port + "] failed.");
            }
            return _connected;
        }

        public void Close()
        {
            if (log.IsDebugEnabled) log.Debug("Closing connection.");
            _lib.Close();
            _port = "";
            _connected = false;
        }

        /// <summary>
        /// Send an active ping to the adapter and updates connection state
        /// </summary>
        /// <returns>True if adapter is connected and alive</returns>
        public bool Ping()
        {
            bool ping = _lib.PingAdapter();
            if (!ping && log.IsErrorEnabled) log.Error("Lost connection while watchdog adapter (Ping).");
            if (!ping) { _connected = false; _port = ""; }
            return ping;
        }

        #endregion

        #region Power/Standby CEC functions

        public bool WakeDevice(CecLogicalAddress address)
        {
            bool res = _lib.PowerOnDevices(address);
            if (log.IsDebugEnabled) log.Debug("Wake [" + address.ToString() + "] ... " + (res ? "Done." : "Failed."));
            return res;
        }

        public bool WakeDevice(CecLogicalAddresses device)
        {
            bool ret = true;
            foreach (CecLogicalAddress a in device.Addresses)
            {
                if (a != CecLogicalAddress.Unknown)
                {
                    if (!WakeDevice(a))
                    {
                        ret = false;
                    }
                }
            }
            return ret;
        }

        public bool SetSource(bool active)
        {
            if (active)
            {
                if (log.IsDebugEnabled) log.Debug("Sent active source.");
                return _lib.SetActiveSource(CecDeviceType.Reserved);
            }

            if (log.IsDebugEnabled) log.Debug("Sent inactive source.");
            return _lib.SetInactiveView();
        }

        public bool StandByDevice(CecLogicalAddress device)
        {
            bool res = _lib.StandbyDevices(device);
            if (log.IsDebugEnabled) log.Debug("Put [" + device.ToString() + "] to standby mode ... " + (res ? "Done." : "Failed."));
            return res;
        }

        public bool StandByDevice(CecLogicalAddresses device)
        {
            bool ret = true;
            foreach (CecLogicalAddress a in device.Addresses)
            {
                if (a != CecLogicalAddress.Unknown)
                {
                    if (!StandByDevice(a))
                    {
                        ret = false;
                    }
                }
            }
            return ret;
        }

        public CecPowerStatus PowerStatus(CecLogicalAddress address)
        {
            CecPowerStatus ret = _lib.GetDevicePowerStatus(address);
            if (log.IsDebugEnabled) log.Debug("Power status of [" + address.ToString() + "] is [" + ret.ToString() + "]");
            return ret;
        }

        public bool IsActiveSource(CecLogicalAddress address)
        {
            bool res = _lib.IsActiveSource(address);
            if (log.IsDebugEnabled) log.Debug("Is [" + address.ToString() + "] active source? " + (res ? "Yes." : "No/Unknown."));
            return res;
        }

        public bool IsActiveSource()
        {
            bool res = IsActiveSource(_lib.GetLogicalAddresses().Primary);
            //if (log.IsDebugEnabled) log.Debug("Is [libCEC] active source? " + (res ? "Yes." : "No/Unknown."));
            return res;
        }

        #endregion

        #region Special operations

        private void wakeUpOtherDevices()
        {
            String file = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"powerList.cfg");
            if (!File.Exists(file))
            {
                if (log.IsErrorEnabled) log.Error("Failed to load wake up config file. File [" + file + "] was not found.");
                return;
            }

            StreamReader str = new StreamReader(file);
            String line;
            while ((line = str.ReadLine()) != null)
            {
                if (line.Contains("="))
                {
                    String[] spl = line.Split('=');
                    if (spl.Length >= 2)
                    {
                        switch (spl[0].Trim())
                        {
                            case "WakeUp":
                                String[] devices = spl[1].Trim().Split(',');
                                foreach (String device in devices)
                                {
                                    Int32 deviceAddress = -1;
                                    if (Int32.TryParse(device.Trim(), out deviceAddress))
                                        WakeDevice((CecLogicalAddress)deviceAddress);
                                }
                                break;
                        }
                    }
                }
            }
            str.Close();
        }

        private void standbyOtherDevices()
        {
            String file = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "powerList.cfg");
            if (!File.Exists(file))
            {
                if (log.IsErrorEnabled) log.Error("Failed to load standby config file. File [" + file + "] was not found.");
                return;
            }

            StreamReader str = new StreamReader(file);
            String line;
            while ((line = str.ReadLine()) != null)
            {
                if (line.Contains("="))
                {
                    String[] spl = line.Split('=');
                    if (spl.Length >= 2)
                    {
                        switch (spl[0].Trim())
                        {
                            case "Standby":
                                String[] devices = spl[1].Trim().Split(',');
                                foreach (String device in devices)
                                {
                                    Int32 deviceAddress = -1;
                                    if (Int32.TryParse(device.Trim(), out deviceAddress))
                                        StandByDevice((CecLogicalAddress)deviceAddress);
                                }
                                break;
                        }
                    }
                }
            }
            str.Close();
        }

        #endregion

        public bool Poll(CecLogicalAddress address)
        {
            return _lib.PollDevice(address);
        }

        public CecVendorId getVendorId(CecLogicalAddress address)
        {
            return _lib.GetDeviceVendorId(address);
        }
        
        /// <summary>
        /// Internal connection state. Better use active connection check via Ping()
        /// </summary>
        public bool Connected
        {
            get { return _connected; }
        }
        public byte HDMIPort
        {
            get { return _config.HDMIPort; }
        }
        public CecVersion CECVersion
        {
            get { return _config.CECVersion; }
        }
        public CecLogicalAddresses Addresses
        {
            get { return _lib.GetLogicalAddresses(); }
        }
        public CEC_Adapter[] Adapters 
        { 
            get 
            { 
                CecAdapter[] adapters = _lib.FindAdapters(string.Empty); 
                CEC_Adapter[] ret = new CEC_Adapter[adapters.Length];
                for (int i = 0; i < adapters.Length; i++)
                {
                    ret[i] = new CEC_Adapter(adapters[i].Path, adapters[i].ComPort);
                }
                return ret;
            }
        }
        public String Port
        {
            get
            {
                return _port;
            }
        }     
        public String DeviceName { get { return _config.DeviceName; } }
        public int LogLevel { get { return _logLevel; } set { _logLevel = value; } }

        #region Backward event handler

        public event KeyPressEventHandler OnKeyPress = null;
        public delegate void KeyPressEventHandler(object sender, CEC_KeyPressEventArgs e);

        public event SourceActivatedEventHandler OnSourceActivated = null;
        public delegate void SourceActivatedEventHandler(object sender, CEC_SourceActivatedEventArgs e);

        public event StandbyEventHandler OnStandby = null;
        public delegate void StandbyEventHandler(object sender, CEC_StandbyEventArgs e);

        public event PowerStatusChangedEventHandler OnPowerStateChanged = null;
        public delegate void PowerStatusChangedEventHandler(object sender, CEC_PowerStatusChangedEventArgs e);

        #endregion

    }
}
