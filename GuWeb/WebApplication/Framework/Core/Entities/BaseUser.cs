using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseUser
    {
        public User User { get; set; }
        public UserInformation UserInformation { get; set; }
        public ScoreLevel ScoreLevel { get; set; }
    }
}
