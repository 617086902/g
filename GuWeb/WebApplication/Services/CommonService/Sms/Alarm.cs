using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.BitterMelon.Entities;
using TF.BitterMelon.Tool;

namespace CommonService.Sms
{
    public class Alarm
    {
        private static Dictionary<int, string> templateDic = new Dictionary<int, string>
        {
            {1,"微博数据抓取失败，登陆账号#phone#，请尽快检查处理！" }
        };
        public static void SendAlarmMsg(string phone, int type)
        {
            string filePath = ConstStr.WeiboContentPath("alarm");
            var content = FileOperate.ReadFile(filePath);
            AlarmModel alarm = new AlarmModel
            {
                phone = phone,
                type = type,
                date = DateTime.Now,
                content = templateDic[type].Replace("#phone#", Core.Utilities.ConfigHelper.Get("WeiboUserCode"))
            };
            if (content != "不存在相应的目录")
            {
                List<string> alarmList = FileOperate.Read(filePath);
                List<AlarmModel> amlist = new List<AlarmModel>();
                foreach (var a in alarmList)
                {
                    if (string.IsNullOrEmpty(a)) continue;
                    var m = Newtonsoft.Json.JsonConvert.DeserializeObject<AlarmModel>(a);
                    if (m != null)
                        amlist.Add(m);
                }
                DateTime dt = DateTime.Now;
                if (amlist.Any(a => a.phone == phone && a.type == type && dt.Subtract(a.date).TotalHours <= 10))
                    return;
            }
            FileOperate.WriteFile(filePath, Newtonsoft.Json.JsonConvert.SerializeObject(alarm));
            SmsHelper.Send(phone, alarm.content);
        }

        public class AlarmModel
        {
            public string phone { get; set; }
            public int type { get; set; }
            public DateTime date { get; set; }
            public string content { get; set; }
        }
    }
}
