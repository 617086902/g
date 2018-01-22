using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FileHelper
    {
        public static HashSet<string> Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            HashSet<string> badwords = new HashSet<string>();
            while ((line = sr.ReadLine()) != null && !badwords.Contains(line))
            {
                badwords.Add(line);
            }
            return badwords;
        }
        public static string ReadAll(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            return sr.ReadToEnd();
        }
    }
}
