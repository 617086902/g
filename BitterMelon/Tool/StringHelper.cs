using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.Tool
{
    public class StringHelper
    {
        public static string CharAt(string s,int index)
        {
            if ((index >= s.Length) || (index < 0))
                return "";
            return s.Substring(index, 1);
        }
    }
}
