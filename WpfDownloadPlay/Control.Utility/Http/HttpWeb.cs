using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Control.Utility.Http
{
    public class HttpWeb
    {
        public string HttpPost(string url,string postDataStr)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method="post";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            Stream myRequestStream = httpWebRequest.GetRequestStream();
            StreamWriter streamWriter = new StreamWriter(myRequestStream,Encoding.GetEncoding("utf-8"));
            streamWriter.Write(postDataStr);
            streamWriter.Close();

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            Stream myResponseStream = httpWebResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

            string retString = streamReader.ReadToEnd();
            streamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public string HttpGet(string url, string getDataStr)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url + (getDataStr == "" ? "" : "?") + getDataStr);
            httpWebRequest.Method = "get";
            httpWebRequest.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream myResponseStream = httpWebResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

            string retString = streamReader.ReadToEnd();
            streamReader.Close();
            myResponseStream.Close();

            return retString;
        }
    }
}
