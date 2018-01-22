using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Entities
{
    public class UserPost
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string StockCode { get; set; }
        public string GubaName { get; set; }
        public int CommentCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ShowDate { get; set; }
    }
}
