using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Entities
{
    public class CommentDetials : ScoreBase
    {
        public string UserName { get; set; }
        public string ProfilePhoto { get; set; }
        public string CreatedDate { get; set; }
        public Comment Comment { get; set; }
        public IEnumerable<CommentDetials> CommentReply { get; set; }

    }
}
