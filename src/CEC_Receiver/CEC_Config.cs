﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CecSharp;

namespace billy_boy.CEC_Receiver
{
    public class CEC_Config
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static CecDeviceType DeviceType = CecDeviceType.RecordingDevice;
        public static String DeviceName = "HTPC";
        public static int ConnectionTimeout = 2000;
        public static CecLogLevel CEC_LogLevel = CecLogLevel.All;
        public static CecVendorId CEC_Vendor = CecVendorId.Samsung;
        public static byte HDMI_Port = 3;
        public static CecClientVersion CEC_ClientVersion = CecClientVersion.CurrentVersion;
        public static CecLogicalAddress CEC_BaseDevice = CecLogicalAddress.AudioSystem;

        public static void importConfig(String file)
        {
            if (!File.Exists(file))
            {
                if (log.IsErrorEnabled) log.Error("Failed to load config file. File ["+file+"] was not found.");
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
                            case "DeviceType": DeviceType = (CecDeviceType)Int32.Parse(spl[1].Trim()); break;
                            case "DeviceName": DeviceName = spl[1].Trim(); break;
                            case "ConnectionTimeout": ConnectionTimeout = Int32.Parse(spl[1].Trim()); break;
                            case "CEC_LogLevel": CEC_LogLevel = (CecLogLevel)Int32.Parse(spl[1].Trim()); break;
                            case "CEC_Vendor": CEC_Vendor = (CecVendorId)Int32.Parse(spl[1].Trim()); break;
                            case "HDMI_Port": HDMI_Port = Byte.Parse(spl[1].Trim()); break;
                            case "CEC_BaseDevice": CEC_BaseDevice = (CecLogicalAddress)Int32.Parse(spl[1].Trim()); break;
                        }
                    }
                }
            }
            str.Close();
        }

        public static void saveConfig(String file)
        {
            if (!File.Exists(file))
            {
                if (log.IsInfoEnabled) log.Info("Saving libCEC configuraton to new file ["+file+"]");
            }
            else
            {
                if (log.IsInfoEnabled) log.Info("Saving libCEC configuraton to existing file ["+file+"]");            
            }
            File.WriteAllText(file,CEC_Config.ToString());
        }

        public static String ToString()
        {
            String res =
                "DeviceType=" + ((Int32)DeviceType).ToString() + "\r\n" +
                "DeviceName=" + DeviceName + "\r\n" +
                "ConnectionTimeout=" + ((Int32)ConnectionTimeout).ToString() + "\r\n" +
                "CEC_LogLevel=" + ((Int32)CEC_LogLevel).ToString() + "\r\n" +
                "CEC_Vendor=" + ((Int32)CEC_Vendor).ToString() + "\r\n" +
                "HDMI_Port=" + ((byte)HDMI_Port).ToString() + "\r\n" +
                "CEC_BaseDevice=" + ((Int32)CEC_BaseDevice).ToString() + "\r\n";
            return res;
        }
    }
}
