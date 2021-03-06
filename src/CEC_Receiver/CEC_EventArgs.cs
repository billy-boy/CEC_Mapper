﻿using System;
using System.Collections.Generic;
using System.Text;

namespace billy_boy.CEC_Receiver
{
    public class CEC_KeyPressEventArgs : EventArgs
    {
        public Int32 KeyCode { get; set; }
        public bool KeyDown { get; set; }       //True -> KeyDown, False -> KeyUp
    }
    
    public enum CEC_LogMessageLevel { Error, Warning, Notice, Traffic, Debug, None }
    public class CEC_LogMessageEventArgs : EventArgs
    {
        public String Message { get; set; }
        public long Time { get; set; }
        public CEC_LogMessageLevel Level { get; set; }
    }

    public class CEC_SourceActivatedEventArgs : EventArgs
    {
        public bool Activated { get; set; }
    }

    public class CEC_PowerStatusChangedEventArgs : EventArgs
    {
        public byte PowerStatus { get; set; }
        public CecSharp.CecLogicalAddress Device { get; set; }
    }

    public class CEC_StandbyEventArgs : EventArgs
    {
        public CecSharp.CecLogicalAddress Device { get; set; }
    }

}
