using System.Collections.Generic;

namespace TF.BitterMelon.Entities
{

    public class Head
    {
        public Head()
        {
            Meta = new Dictionary<string, string>();
        }        
        public string Title { get; set; }
        public string Charset { get; set; }
        public Dictionary<string, string> Meta { get; set; }
    }
}
