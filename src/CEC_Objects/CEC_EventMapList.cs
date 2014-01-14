using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace billy_boy.CEC_Objects
{
    public class CEC_EventMapList : System.Collections.CollectionBase
    {
        public CEC_EventMapList()
		{
		}

        public void Add(CEC_EventMap item)
		{
            if (!base.InnerList.Contains(item))
                base.InnerList.Add(item);
		}

        public void Remove(CEC_EventMap item)
        {
            base.InnerList.Remove(item);
        }

        public bool Contains(CEC_EventMap item)
        {
            foreach (CEC_EventMap s in base.InnerList)
            {
                if (s == item)
                    return true;
            }
            return false;
        }

        public bool Contains(billy_boy.CEC_Objects.CEC_Enums.CEC_Event cec_event)
        {
            foreach (CEC_EventMap s in base.InnerList)
            {
                if (s.CEC_Event == cec_event)
                    return true;
            }
            return false;
        }

        public CEC_EventMap this[int index]
		{
			get
			{
                return (CEC_EventMap)base.InnerList[index];

			}
		}

        public CEC_EventMap this[billy_boy.CEC_Objects.CEC_Enums.CEC_Event cec_event]
        {
            get
            {
                foreach (CEC_EventMap s in base.InnerList)
                {
                    if (s.CEC_Event == cec_event)
                        return s;
                }
                return null;
            }
        }
    }
}
