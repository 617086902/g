using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Entities
{
    public class HotPost
    {
        public string UserName { get; set; }
        public string PostTitle { get; set; }
        public string GubaName { get; set; }
        public int HotValue { get; set; }
        public int PostId { get; set; }
        public string StockCode { get; set; }
    }
}
