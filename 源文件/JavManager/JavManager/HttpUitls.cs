using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace JavManager
{
    class HttpUitls
    {
        public static string Get(string Url)
        {
            //System.GC.Collect();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            //request.Proxy = null;
            //request.KeepAlive = false;
            request.Method = "GET";
            //request.ContentType = "application/json; charset=UTF-8";
            //request.AutomaticDecompression = DecompressionMethods.GZip;
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse() as HttpWebResponse;
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();

                myStreamReader.Close();
                myResponseStream.Close();

                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
                return retString;
            }
            catch (Exception e)
            {
                return "error";
            }

            
            //return jsonstr;
        }

    }
}
