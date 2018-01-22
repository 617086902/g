using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.Utilities {
    public class SessionHelper {

        /// <summary>
        /// 获取session值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSession(string key) {
            if (HttpContext.Current.Session[key] == null) return null;
            return HttpContext.Current.Session[key] as string;
        }
        /// <summary>
        /// 获取session值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetSession<T>(string key) {
            if (HttpContext.Current.Session[key] == null) return default(T);
            return (T)HttpContext.Current.Session[key];
        }

        /// <summary>
        /// session是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Exist(string key) {
            return HttpContext.Current.Session[key] != null;
        }


        /// <summary>
        /// 设置session
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetSession(string key, object value) {
            HttpContext.Current.Session[key] = value;
        }

        /// <summary>
        /// 删除session
        /// </summary>
        /// <param name="key"></param>
        public static void DeleteSession(string key) {
            HttpContext.Current.Session.Remove(key);
        }
    }
}
