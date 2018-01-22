using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Entities {
    public class CommentListModel : PageBase {
        public IEnumerable<CommentDetials> CommentData { get; set; }
    }
}
