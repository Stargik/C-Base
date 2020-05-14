using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Dictionary<TKey, TValue>
    {
        TKey[] keys = new TKey[0];
        TValue[] values = new TValue[0];
        
        public TValue this[TKey key]
        {
            get
            {
                TValue value = values[0];
                for (int i = 0; i < keys.Length; i++)
                {
                    if ((object)keys[i] == (object)key)
                    {
                        value = values[i];
                    }
                    
                }
                return value;
            }
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] cloudKeys = new TKey[keys.Length + 1];
            TValue[] cloudValues = new TValue[values.Length + 1];
            for (int i = 0; i < keys.Length; i++)
            {
                cloudKeys[i] = keys[i];
                cloudValues[i] = values[i];
            }
            cloudKeys[keys.Length] = key;
            cloudValues[values.Length] = value;
            keys = cloudKeys;
            values = cloudValues;
        }

        int count;
        public int Count
        {
            get
            {
                return keys.Length;
            }
        }
    }
}
