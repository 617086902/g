using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities {
    public class SessionKey {
        public static string CurrentUser = "CurrentUser";

        public static string OAuthAccessTokenResult = "OAuthAccessTokenResult";

        public static string OpenId { get { return "OpenId"; } }
        public static string WeixinCode { get { return "WeixinCode"; } }
        public static string SMS { get { return "SMS"; } }
        public static string RegistValidCode { get { return "RegistValidCode"; } }
        public static string ValidMobile { get { return "ValidMobile"; } }
        public static string ValidUserAccount { get { return "ValidUserAccount"; } }
        public static string ValidCode { get { return "ValidCode"; } }
        public static string lastSendTime { get { return "lastSendTime"; } }
        public static string SendMessageTimes { get { return "SendMessageTimes"; } }
        public static string ReturnURL { get { return "ReturnURL"; } }
        public static string RequestState { get { return "RequestState"; } }
    }
}
