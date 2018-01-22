using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.Tool
{
    public class ScriptHelper
    {
        public static string RunJsReadPath(string jsPath,string funStr)
        {
            string path = jsPath;
            string scriptStr = File.ReadAllText(path);
            string result = ExecuteScript(funStr, scriptStr);
            return result;
        }

        public static string RunJs(string jsStr,string funStr)
        {
            string result = ExecuteScript(funStr, jsStr);
            return result;
        }

        public static string ExecuteScript(string sExpression, string sCode)
        {
            MSScriptControl.ScriptControl scriptControl = new MSScriptControl.ScriptControl();
            scriptControl.UseSafeSubset = true;
            scriptControl.Language = "JScript";
            scriptControl.AddCode(sCode);
            try
            {
                string str = scriptControl.Eval(sExpression).ToString();
                return str;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            return "";
        }
    }
}
