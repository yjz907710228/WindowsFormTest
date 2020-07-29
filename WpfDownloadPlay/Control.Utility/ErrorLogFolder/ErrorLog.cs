using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Control.Utility.ErrorLogFolder
{
    public static class ErrorLog
    {
        public static string strLogFile = "ErrorLog.txt";
        public static StreamWriter sw = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objException">异常</param>
        /// <returns></returns>
        public static bool WriteErrorLog(Exception objException)
        {
            bool bReturn = false;
            string strException = string.Empty;
            try
            {
                sw = new StreamWriter(strLogFile, true);
                sw.WriteLine("Source : " + objException.Source.ToString().Trim());
                sw.WriteLine("Method : " + objException.TargetSite.Name.ToString());
                sw.WriteLine("Date : " + DateTime.Now.ToLongTimeString());
                sw.WriteLine("Time : " + DateTime.Now.ToShortDateString());
                sw.WriteLine("Computer : " + Dns.GetHostName().ToString());
                sw.WriteLine("Error : " + objException.Message.ToString().Trim());
                sw.WriteLine("Stack Trace : " + objException.StackTrace.ToString().Trim());
                sw.WriteLine("^^-------------------------------------------------------------------^^");
                sw.Flush();
                sw.Close();
                bReturn = true;
            }
            catch (Exception)
            {
                bReturn = false;
            }
            return bReturn;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Source">来源</param>
        /// <param name="Method">方法</param>
        /// <param name="Error">错误</param>
        /// <returns></returns>
        public static bool WriteErrorLog(String Source, String Method, String Error)
        {
            bool bReturn = false;
            string strException = string.Empty;
            try
            {
                sw = new StreamWriter(strLogFile, true);
                sw.WriteLine("Source : " + Source);
                sw.WriteLine("Method : " + Method);
                sw.WriteLine("Date : " + DateTime.Now.ToLongTimeString());
                sw.WriteLine("Time : " + DateTime.Now.ToShortDateString());
                sw.WriteLine("Computer : " + Dns.GetHostName().ToString());
                sw.WriteLine("Error : " + Error);
                //sw.WriteLine("Stack Trace : " + objException.StackTrace.ToString().Trim());
                sw.WriteLine("^^-------------------------------------------------------------------^^");
                sw.Flush();
                sw.Close();
                bReturn = true;
            }
            catch (Exception)
            {
                bReturn = false;
            }
            return bReturn;
        }


    }
}
