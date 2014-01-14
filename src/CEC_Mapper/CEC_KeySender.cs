using billy_boy.CEC_Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowsInput;

namespace billy_boy.CEC_Mapper
{
    public class CEC_KeySender
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region DEPRECATED / UNUSED

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, uint wParam, uint lParam);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

        #endregion

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr handle, out uint processId);

        #region DEPRECATED / UNUSED

        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;

        public const int VK_SHIFT = 0x10;
        public const int VK_CONTROL = 0x11; //STRG
        public const int VK_MENU = 0x12;    //ALT

        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/ms646270(v=vs.85).aspx
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct INPUT
        {
            public uint Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        /// <summary>
        /// http://social.msdn.microsoft.com/Forums/en/csharplanguage/thread/f0e82d6e-4999-4d22-b3d3-32b25f61fb2a
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public HARDWAREINPUT Hardware;
            [FieldOffset(0)]
            public KEYBDINPUT Keyboard;
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/ms646310(v=vs.85).aspx
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct HARDWAREINPUT
        {
            public uint Msg;
            public ushort ParamL;
            public ushort ParamH;
        }

        /// <summary>
        /// http://msdn.microsoft.com/en-us/library/windows/desktop/ms646310(v=vs.85).aspx
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct KEYBDINPUT
        {
            public ushort Vk;
            public ushort Scan;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        /// <summary>
        /// http://social.msdn.microsoft.com/forums/en-US/netfxbcl/thread/2abc6be8-c593-4686-93d2-89785232dacd
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct MOUSEINPUT
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        #endregion

        /// <summary>
        /// Checks wether a given process name is owener of the actual foreground window
        /// </summary>
        /// <param name="processName">Name of the process to check for</param>
        /// <returns>true if the name of the forground windows process matches</returns>
        private static bool checkProcessIsForeground(String processName)
        {
            if (log.IsDebugEnabled) log.Debug("Checking for foreground process. Check for [" + processName + "].");
            IntPtr foregroundWindow = GetForegroundWindow();
            if (log.IsDebugEnabled) log.Debug("Actual Windows foreground window has handle [" + foregroundWindow.ToInt32().ToString() + "].");
            if (foregroundWindow == IntPtr.Zero)
                return false;
            uint processId = 0;
            uint threadId = 0;
            threadId = GetWindowThreadProcessId(foregroundWindow, out processId);
            if (log.IsDebugEnabled) log.Debug("Details of foreground window: process [" + processId.ToString() + "] thread ["+threadId.ToString()+"].");
            Process process = System.Diagnostics.Process.GetProcessById((Int32)processId);          
            if (process == null)
                return false;
            if (log.IsDebugEnabled) log.Debug("More Details of process [" + process.Id.ToString() + "]: Name [" + process.ProcessName.ToString() + "].");
            if (log.IsDebugEnabled) log.Debug("Check if [" + process.ProcessName.ToLower().Trim() + "] matches [" + processName.ToLower().Trim() + "].");
            if (process.ProcessName.ToLower().Trim() == processName.ToLower().Trim())
            {
                if (log.IsDebugEnabled) log.Debug("-> It does.");
                return true;
            }
            if (log.IsDebugEnabled) log.Debug("-> It does not.");
            return false;
        }
        
        /// <summary>
        /// Detects the name of the process of the owner of the acutal Windows foreground window
        /// </summary>
        /// <returns>The process's name</returns>
        private static String getForegroundProcessName()
        {
            if (log.IsDebugEnabled) log.Debug("Detecting foreground process name.");
            IntPtr foregroundWindow = GetForegroundWindow();
            if (log.IsDebugEnabled) log.Debug("Actual Windows foreground window has handle [" + foregroundWindow.ToInt32().ToString() + "].");
            if (foregroundWindow == IntPtr.Zero)
                return String.Empty;
            uint processId = 0;
            uint threadId = 0;
            threadId = GetWindowThreadProcessId(foregroundWindow, out processId);
            if (log.IsDebugEnabled) log.Debug("Details of foreground window: process [" + processId.ToString() + "] thread [" + threadId.ToString() + "].");
            Process process = System.Diagnostics.Process.GetProcessById((Int32)processId);
            if (process == null)
                return String.Empty;
            if (log.IsDebugEnabled) log.Debug("More Details of process [" + process.Id.ToString() + "]: Name [" + process.ProcessName + "].");
            return process.ProcessName;
        }

        /// <summary>
        /// Send the corresponding keyboard key detected from config to a given CEC key to the foreground window (if that is in config)
        /// </summary>
        /// <param name="cec_key">CEC keycode to lookup</param>
        public static void SendMapingKey(int cec_key)
        {
            String foregroundProcess = getForegroundProcessName();
            if (log.IsDebugEnabled) log.Debug("Actual Windows foreground window's process name [" + foregroundProcess + "]. Check for existing KeyMap for [" + foregroundProcess.ToLower().Trim() + "].");
            CEC_Process process = CEC_ProcessList.getInstance()[foregroundProcess.ToLower().Trim()];
            if (process == null)
            {
                if (log.IsWarnEnabled) log.Warn("Received CEC key input ["+cec_key.ToString()+"]. No KeyMap found for foreground process ["+foregroundProcess.ToLower().Trim()+"]. Exiting.");
                return;
            }
            CEC_KeyboardKey keyboard_key = process.getMapping(cec_key).Keyboard_Key;
            if (keyboard_key.Type == CEC_KeyboardKey.CEC_KeyboardKey_Type.Key) SendKey(cec_key, keyboard_key, foregroundProcess);
            else if (keyboard_key.Type == CEC_KeyboardKey.CEC_KeyboardKey_Type.Makro) RunMakro(cec_key, keyboard_key, foregroundProcess);

        }

        private static void SendKey(int cec_key, CEC_KeyboardKey keyboard_key, String foregroundProcess)
        {
            if (keyboard_key.Type != CEC_KeyboardKey.CEC_KeyboardKey_Type.Key) return;

            Keys keyboard_keys = keyboard_key.Keys;
            if (log.IsInfoEnabled) log.Info("Received CEC key input [" + cec_key.ToString() + "]. Send key [" + keyboard_keys.ToString() + "" + ((keyboard_keys & Keys.Shift) == Keys.Shift ? " + SHIFT" : "") + ((keyboard_keys & Keys.Alt) == Keys.Alt ? " + ALT" : "") + ((keyboard_keys & Keys.Control) == Keys.Control ? " + CTRL" : "") + "] to foreground process [" + foregroundProcess.ToLower().Trim() + "].");

            if ((keyboard_keys & Keys.Shift) == Keys.Shift) { InputSimulator.SimulateKeyDown(VirtualKeyCode.SHIFT); }
            if ((keyboard_keys & Keys.Alt) == Keys.Alt) { InputSimulator.SimulateKeyDown(VirtualKeyCode.MENU); }
            if ((keyboard_keys & Keys.Control) == Keys.Control) { InputSimulator.SimulateKeyDown(VirtualKeyCode.CONTROL); }
            InputSimulator.SimulateKeyPress((VirtualKeyCode)(ushort)keyboard_keys);
            if ((keyboard_keys & Keys.Control) == Keys.Control) { InputSimulator.SimulateKeyUp(VirtualKeyCode.CONTROL); }
            if ((keyboard_keys & Keys.Alt) == Keys.Alt) { InputSimulator.SimulateKeyUp(VirtualKeyCode.MENU); }
            if ((keyboard_keys & Keys.Shift) == Keys.Shift) { InputSimulator.SimulateKeyUp(VirtualKeyCode.SHIFT); }
        }

        private static void RunMakro(int cec_key, CEC_KeyboardKey keyboard_key, String foregroundProcess)
        {
            if (keyboard_key.Type != CEC_KeyboardKey.CEC_KeyboardKey_Type.Makro) return;

            ProcessStartInfo makro = keyboard_key.Makro;
            if (log.IsInfoEnabled) log.Info("Received CEC key input [" + cec_key.ToString() + "]. Running makro [" + makro.FileName + "] with args [" + makro.Arguments + "] because of foreground process [" + foregroundProcess.ToLower().Trim() + "].");
            Process.Start(makro);
        }

        #region DEPRECATED / UNUSED

        /// <summary>
        /// simulate key press
        /// </summary>
        /// <param name="keyCode"></param>
        public static void SendKeyPress(ushort keyCode)
        {
            INPUT input = new INPUT
            {
                Type = 1
            };
            input.Data.Keyboard = new KEYBDINPUT()
            {
                Vk = (ushort)keyCode,
                Scan = 0,
                Flags = 0,
                Time = 0,
                ExtraInfo = IntPtr.Zero,
            };

            INPUT input2 = new INPUT
            {
                Type = 1
            };
            input2.Data.Keyboard = new KEYBDINPUT()
            {
                Vk = (ushort)keyCode,
                Scan = 0,
                Flags = 2,
                Time = 0,
                ExtraInfo = IntPtr.Zero
            };
            INPUT[] inputs = new INPUT[] { input, input2 };
            if (SendInput(2, inputs, Marshal.SizeOf(typeof(INPUT))) == 0)
                throw new Exception();
        }

        /// <summary>
        /// Send a key down and hold it down until sendkeyup method is called
        /// </summary>
        /// <param name="keyCode"></param>
        public static void SendKeyDown(ushort keyCode)
        {
            INPUT input = new INPUT
            {
                Type = 1
            };
            input.Data.Keyboard = new KEYBDINPUT();
            input.Data.Keyboard.Vk = (ushort)keyCode;
            input.Data.Keyboard.Scan = 0;
            input.Data.Keyboard.Flags = 0;
            input.Data.Keyboard.Time = 0;
            input.Data.Keyboard.ExtraInfo = IntPtr.Zero;
            INPUT[] inputs = new INPUT[] { input };
            if (SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT))) == 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Release a key that is being hold down
        /// </summary>
        /// <param name="keyCode"></param>
        public static void SendKeyUp(ushort keyCode)
        {
            INPUT input = new INPUT
            {
                Type = 1
            };
            input.Data.Keyboard = new KEYBDINPUT();
            input.Data.Keyboard.Vk = (ushort)keyCode;
            input.Data.Keyboard.Scan = 0;
            input.Data.Keyboard.Flags = 2;
            input.Data.Keyboard.Time = 0;
            input.Data.Keyboard.ExtraInfo = IntPtr.Zero;
            INPUT[] inputs = new INPUT[] { input };
            if (SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT))) == 0)
                throw new Exception();

        }

        #endregion
    }
}
