using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.Entities
{
    public class HtmlDom
    {
        public Queue<Node> NodeQueue { get; set; }
    }

    public class Node
    {
        public string Content { get; set; }
        public int Level { get; set; }
    }
}
