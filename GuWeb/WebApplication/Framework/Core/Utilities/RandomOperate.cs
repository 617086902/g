using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class RandomOperate
    {

        public static string RandomName(int length)
        {
            Guid g = Guid.NewGuid();
            string res = g.ToString().Replace("-", "").Substring(0, length);
            return res;
        }

        /// <summary>
        /// 返回随机数字串
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RandomNumCode(int length)
        {
            string nums = "0123456789", code = "";
            Random random = new Random();
            for (int i = 0; i < length; i++) code += nums[random.Next(0, 10)];
            return code;
        }
    }
}
