using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TF.BitterMelon.Tool
{
    public class UnicodeHelper
    {
        public static string UnicodeToString(string str)
        {
            string outStr = str;
            try
            {
                outStr = outStr.Replace("\\u", "~^^~^");
                Regex reg = new Regex(@"\~\^\^\~\^(?<key>[\s\S]{4})");
                Match m = reg.Match(outStr);
                while (m.Success)
                {
                    try
                    {
                        char c = (char)int.Parse(m.Value.Replace("~^^~^", ""), System.Globalization.NumberStyles.HexNumber);
                        outStr = outStr.Replace(m.Value, c.ToString());
                        m = m.NextMatch();
                    }
                    catch (Exception exa)
                    {
                        m = m.NextMatch();
                    }
                }
            }
            catch (FormatException ex)
            {
                outStr = str;
            }
            return outStr;
        }
    }
}
