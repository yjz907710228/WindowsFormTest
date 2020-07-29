using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDownloadPlay
{
    public static class CommonStatic
    {
        public static Hashtable CommonHashTable = Hashtable.Synchronized(new Hashtable());

        public static bool AddForKey(object key,object value)
        {
            bool flag = true;
            if (CommonHashTable.Contains(key))
            {
                flag = false;
            }
            else
            {
                CommonHashTable.Add(key, value);
            }
            
            return flag;
        }

        public static bool CheckValue(object value)
        {
            bool flag = true;
            if (CommonHashTable.ContainsValue(value))
            {
                flag = false;
            }
            else
            {
                
            }
            return flag;
        }

        public static bool RemoveForKey(object key)
        {
            bool flag = true;
            if (CommonHashTable.Contains(key))
            {
                CommonHashTable.Remove(key);
            }
            return flag;
        }

        public static void ClearHashTable()
        {
            CommonHashTable.Clear();
        }
    }
}
