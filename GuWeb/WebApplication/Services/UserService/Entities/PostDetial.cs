using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Entities
{
    public class PostDetial : ScoreBase
    {
        public string UserName { get; set; }
        public string ProfilePhoto { get; set; }
        public string StockName { get; set; }
        public int CommontCount { get; set; }
        public string ShowTime { get; set; }
        public Post Post { get; set; }

    }
}
