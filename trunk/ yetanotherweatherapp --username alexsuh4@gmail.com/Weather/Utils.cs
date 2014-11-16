using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Reflection;

namespace Weather
{
    public class Utils
    {
        public static Random Rand = new Random(DateTime.Now.Millisecond);
        public static string GetFromWeb(string uri, string where)
        {
            if (File.Exists(where))
                File.Delete(where);
            byte[] bytes = GetbytesFrom(uri);
            File.WriteAllBytes(where, bytes);
            //WebClient webClient = new WebClient();
            //webClient.DownloadFile(uri, where);

            return File.ReadAllText(where, Encoding.GetEncoding(Settings1.Default.WeatherXmlEncoding));
        }

        private static byte[] GetbytesFrom(string uri)
        {
             List<byte> total = new List<byte>();
                   
            var req = HttpWebRequest.Create(uri);
            using (var res = req.GetResponse())
            {
                using (Stream st = res.GetResponseStream())
                {
                    const int BUFF_SIZE = 512;
                    byte[] buff = new byte[BUFF_SIZE];
                    int n = 0;
                    while ((n = st.Read(buff, 0, buff.Length)) > 0)
                    {
                        total.AddRange(buff.Take(n));
                    }
                }
            }
            return total.ToArray();
        }
        public static T GetAssemblyAttribute<T>(Assembly assembly) where T : Attribute
        {

            if (assembly == null) return null;

            object[] attributes = assembly.GetCustomAttributes(typeof(T), true);

            if (attributes == null) return null;

            if (attributes.Length == 0) return null;

            return (T)attributes[0];

        }

    }
}
