using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.AnalogLogin.SinaWeibo
{
    [Serializable]
    public class WeiboEntities
    {
        public int retcode { get; set; }
        public string[] arrURL { get; set; }
        public string successURL { get; set; }
        public string callbackURL { get; set; }
    }
}
