using System.Collections.Generic;
/// <summary>
/// 类说明：处理过的html模型
/// 编码日期：2016-06-02
/// 编码人：TF
/// </summary> 
namespace TF.BitterMelon.Entities
{
    public class HtmlModel
    {
        public HtmlModel()
        {
            Head = new Head();
            LinkCollection = new LinkCollection();
            AllScripts = "";
            AllStyles = "";
            LineQueue = new Queue<HtmlLines>();
        }

        public string AllHtml { get; set; }
        public string AllHead { get; set; }
        public string AllBody { get; set; }
        public string AllStyles { get; set; }
        public string AllScripts { get; set; }
        public Head Head { get; set; }
        public LinkCollection LinkCollection { get; set; }
        public Queue<HtmlLines> LineQueue { get; set; }
    }

}
