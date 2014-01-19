using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace billy_boy.CEC_Mapper
{
    public class CEC_ArgumentParser
    {
        public static void parse(ReadOnlyCollection<String> arguments)
        {
            foreach (String argument in arguments)
            {
                CEC_ArgumentParser.parse(argument);
            }
        }
        public static void parse(String argument)
        {
            if (argument.Contains('='))
            {
                String[] spl = argument.Split('=');
                Int32 value = -1;
                switch (spl[0])
                {
                    case "CEC_Wakeup": if (Int32.TryParse(spl[1].Trim(),out value) && CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) { CEC_MapperThread.getInstance().Mapper.Worker.Receiver.WakeDevice((CecSharp.CecLogicalAddress)value); } break;
                    case "CEC_Standby": if (Int32.TryParse(spl[1].Trim(),out value) && CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) { CEC_MapperThread.getInstance().Mapper.Worker.Receiver.StandByDevice((CecSharp.CecLogicalAddress)value); } break;
                }
            }
            else
            {
                switch (argument.Trim())
                {
                    case "CEC_Wakeup": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) { CEC_MapperThread.getInstance().Mapper.Worker.Receiver.WakeDevice(CecSharp.CecLogicalAddress.Tv); CEC_MapperThread.getInstance().Mapper.Worker.Receiver.WakeDevice(CecSharp.CecLogicalAddress.AudioSystem); } break;
                    case "CEC_Standby": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) { CEC_MapperThread.getInstance().Mapper.Worker.Receiver.StandByDevice(CecSharp.CecLogicalAddress.Tv); CEC_MapperThread.getInstance().Mapper.Worker.Receiver.StandByDevice(CecSharp.CecLogicalAddress.AudioSystem); } break;
                    case "CEC_ActiveSource": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) {CEC_MapperThread.getInstance().Mapper.Worker.Receiver.SetSource(true);} break;
                    case "CEC_InactiveSource": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) {CEC_MapperThread.getInstance().Mapper.Worker.Receiver.SetSource(false);} break;
                }
            }
        }


    }
}
