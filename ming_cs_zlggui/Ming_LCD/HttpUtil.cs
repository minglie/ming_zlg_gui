using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace Ming_LCD
{

    public class JsonHelper
    {

        /// <summary>
        /// JavaScriptSerializer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjectToString<T>(T obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(obj);
        }

        /// <summary>
        /// JavaScriptSerializer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public static T StringToObject<T>(string content)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Deserialize<T>(content);
        }

        public static List<T> StringToList<T>(string content)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<T> resdata = jss.Deserialize<List<T>>(content);
            return resdata;
        }







        public static class HttpUtil
        {
            //GET请求
            public static string GetRequest(string url, int Timeout)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                request.UserAgent = null;
                request.Timeout = Timeout;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            /*使用
                string url="Http://127.0.0.1/login.jsp?Name=zhangshi&Age=30&Submit=%cc%E+%BD%BB";
                string res = HttpHelper.GetRequest(url, 6000);
                if (res != null)
                {
                   T mes = JsonHelper.DeserializeJsonToObject<T>(res)
                }
            */


            //获取返回的数据
            public static string GetResponseString(HttpWebResponse webresponse)
            {
                using (Stream s = webresponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(s, Encoding.UTF8);
                    return reader.ReadToEnd();

                }
            }



        }
    }
}