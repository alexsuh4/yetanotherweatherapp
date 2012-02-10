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

        public static string GetFromWeb(string uri,string where)
        {
            if (File.Exists(where))
                File.Delete(where);
            WebClient webClient = new WebClient();
            webClient.DownloadFile(uri, where);

            return File.ReadAllText(where, Encoding.GetEncoding(Settings1.Default.WeatherXmlEncoding) );
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
