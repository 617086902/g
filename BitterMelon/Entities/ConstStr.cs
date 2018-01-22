using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.Entities
{
    public class ConstStr
    {
        public static string GetBaseDir()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            baseDir = baseDir.EndsWith("\\") ? baseDir.Substring(0, baseDir.Length - 1) : baseDir;
            return baseDir;
        }
        public static string WeiboExceptionLog { get { return GetBaseDir() + "\\d\\ERR_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"; } }
        public static string WeiboCookiePath { get { return GetBaseDir() + "\\d\\weiboCookie.txt"; } }
        public static string WeiboContentPath(string k, string d = "")
        {
            if (d == "") d = DateTime.Now.ToString("yyyy-MM-dd");
            return GetBaseDir() + "\\d\\" + k + "_" + d + ".txt";
        }
    }
}
