using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Entities {
    public class PostListModel : PageBase {
        public IEnumerable<PostDetial> PostData { get; set; }
    }
}
