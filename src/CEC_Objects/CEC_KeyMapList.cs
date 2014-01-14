using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace billy_boy.CEC_Objects
{
    public class CEC_KeyMapList : System.Collections.CollectionBase
    {
        public CEC_KeyMapList()
		{
		}

        public void Add(CEC_KeyMap item)
		{
            if (!base.InnerList.Contains(item))
                base.InnerList.Add(item);
		}

        public void Remove(CEC_KeyMap item)
        {
            base.InnerList.Remove(item);
        }

        public bool Contains(CEC_KeyMap item)
        {
            foreach (CEC_KeyMap s in base.InnerList)
            {
                if (s == item)
                    return true;
            }
            return false;
        }

        public bool Contains(int cec_key)
        {
            foreach (CEC_KeyMap s in base.InnerList)
            {
                if (s.CEC_Key == cec_key)
                    return true;
            }
            return false;
        }

        public CEC_KeyMap this[int index]
		{
			get
			{
                return (CEC_KeyMap)base.InnerList[index];

			}
		}

        public CEC_KeyMap this[short cec_key]
        {
            get
            {
                foreach (CEC_KeyMap s in base.InnerList)
                {
                    if (s.CEC_Key == (int)cec_key)
                        return s;
                }
                return null;
            }
        }

        public CEC_KeyMapList OnlyKeys
        {
            get
            {
                CEC_KeyMapList list = new CEC_KeyMapList();
                foreach (CEC_KeyMap map in base.InnerList)
                {
                    if (map.Keyboard_Key.Type == CEC_KeyboardKey.CEC_KeyboardKey_Type.Key)
                        list.Add(map);
                }
                return list;
            }
        }

        public CEC_KeyMapList OnlyMacros
        {
            get
            {
                CEC_KeyMapList list = new CEC_KeyMapList();
                foreach (CEC_KeyMap map in base.InnerList)
                {
                    if (map.Keyboard_Key.Type == CEC_KeyboardKey.CEC_KeyboardKey_Type.Makro)
                        list.Add(map);
                }
                return list;
            }
        }
    }
}
