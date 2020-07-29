using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control.Utility.ErrorLogFolder;

namespace Control.Utility.CollectionList
{
    class CollectionList
    {
        public CollectionList()
        {

        }
        public CollectionList(Hashtable hashtable)
        {
            this.hashtable = hashtable;
        }
        public CollectionList(Object key, Hashtable hashtable)
        {
            this.hashtableKey = key;
            this.hashtable = hashtable;
        }
        private Object hashtableKey;
        private Hashtable hashtable;

        public bool RemoveForKey()
        {
            bool flag = true;
            try
            {

            }
            catch (Exception ex)
            {
                flag = false;
                ErrorLog.WriteErrorLog(ex);
            }
            return flag;
        }
    }
}
