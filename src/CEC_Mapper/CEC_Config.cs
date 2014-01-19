using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace billy_boy.CEC_Mapper
{
    public class CEC_Config
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static String DefaultProcess = "explorer";
        public static bool UseDefaultOnProcessNotFound = true;
        public static bool UseDefaultOnKeyMapNotFound = false;

        public static void importConfig(String file)
        {
            if (!File.Exists(file))
            {
                if (log.IsErrorEnabled) log.Error("Failed to load config file. File [" + file + "] was not found.");
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
                            case "DefaultProcess": DefaultProcess = spl[1].Trim(); break;
                            case "UseDefaultOnProcessNotFound": UseDefaultOnProcessNotFound = Boolean.Parse(spl[1].Trim()); break;
                            case "UseDefaultOnKeyMapNotFound": UseDefaultOnKeyMapNotFound = Boolean.Parse(spl[1].Trim()); break;
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
                if (log.IsInfoEnabled) log.Info("Saving CEC_Mapper configuraton to new file [" + file + "]");
            }
            else
            {
                if (log.IsInfoEnabled) log.Info("Saving CEC_Mapper configuraton to existing file [" + file + "]");
            }
            File.WriteAllText(file, CEC_Config.ToString());
        }

        public static String ToString()
        {
            String res =
                "DefaultProcess=" + DefaultProcess + "\r\n" +
                "UseDefaultOnProcessNotFound=" + UseDefaultOnProcessNotFound.ToString() + "\r\n" +
                "UseDefaultOnKeyMapNotFound=" + UseDefaultOnKeyMapNotFound.ToString() + "\r\n";
            return res;
        }
    }
}
