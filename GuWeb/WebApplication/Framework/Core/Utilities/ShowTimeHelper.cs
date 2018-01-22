using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities {
    public class ShowTimeHelper {
        /// <summary>
        /// 转换成页面展示时间
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertToShowTime(DateTime dt) {
            var datenow = DateTime.Now;
            var ds = datenow - dt;
            if (ds.TotalMinutes <= 1) return "刚刚";
            else if (ds.TotalMinutes <= 60) return Convert.ToInt32(ds.TotalMinutes) + "分钟前";
            else if (ds.TotalHours <= 12) return Convert.ToInt32(ds.TotalHours) + "小时前";
            else if (datenow.Day == dt.Day) return "今天" + dt.ToString("HH:mm");
            else if (datenow.Day == dt.Day + 1) return "昨天" + dt.ToString("HH:mm");
            else return dt.ToString("MM-dd HH:mm");
        }
    }
}
