﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace billy_boy.CEC_Mapper
{
    class Program
    {
        // Create a logger for use in this class
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
 
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingleInstanceController controller = new SingleInstanceController();
            controller.Run(args);
        }
    }

    public class SingleInstanceController : WindowsFormsApplicationBase
    {
        // Create a logger for use in this class
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SingleInstanceController()
        {
            IsSingleInstance = true;
            StartupNextInstance += this_StartupNextInstance;
        }

        void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            //frmMain form = MainForm as frmMain;
            if (log.IsDebugEnabled) log.Debug("User started application even it's running allread... Parsing command line for commands...");
            CEC_ArgumentParser.parse(e.CommandLine);
        }

        protected override void OnCreateMainForm()
        {
            try
            {
                if (!File.Exists(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "LibCecSharp.dll")) || !File.Exists(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "libcec.dll")))
                {
                    if (log.IsWarnEnabled) log.Warn("libCEC DLLs are missing in base directory [" + System.AppDomain.CurrentDomain.BaseDirectory + "]");
                    if (MessageBox.Show("It seems that there is no 'LibCecSharp.dll' and/or 'libcec.dll' inside the programs base directory.\r\nPlease have a look in the Readme before running this program...\r\n\r\nAre you shure to proceed? ", "HDMI CEC Mapper - libCEC missing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                CEC_MapperThread.getInstance().Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The application has crashed. Informations are below.\r\n\r\n"+ex.Message, "HDMI CEC Mapper - Application crash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (log.IsErrorEnabled) log.Error("Application crashed. Reason: " + ex.Message + "");
            }
            if (log.IsDebugEnabled) log.Debug("SingleInstanceController has been started.");
            MainForm = new frmMain();
        }
    }
}
