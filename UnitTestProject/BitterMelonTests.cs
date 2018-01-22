using Microsoft.VisualStudio.TestTools.UnitTesting;
using TF.BitterMelon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.Tests
{
    [TestClass()]
    public class BitterMelonTests
    {
        private string testStr;

        BitterMelon bm;

        public BitterMelonTests()
        {
            testStr = "<!DOCTYPE html><html>";
            testStr += "<head><title>te<st</title>";
            testStr += "<meta name=\"keywords\" content=\"testttt\" />";
            testStr += "<meta name=\"description\" content=\"haha\" />";
            //testStr += "<link rel=\"stylesheet\" type=\"text/css\" href=\"abc\">";
            testStr += "</head>";
            testStr += "<body><a href=\"abc\"><div>abc<span>test</span></div>";
            testStr += "<script>console.log(\"ok\");</script></body></html>";
            bm = new BitterMelon(new Uri("http://www.nichaogu.com/"));
            //bm = new BitterMelon(testStr);
        }
        [TestMethod()]
        public void TitleTest()
        {
            Assert.AreEqual("te<st", bm.Head.Title);
        }
        [TestMethod()]
        public void MetaTest()
        {
            Assert.AreEqual("haha", bm.Head.Meta.ContainsKey("description") ? bm.Head.Meta["description"] : "");
            Assert.AreEqual("testttt", bm.Head.Meta.ContainsKey("keywords") ? bm.Head.Meta["keywords"] : "");
        }
        [TestMethod()]
        public void ScriptsTest()
        {
            Assert.AreEqual("<script>console.log(\"ok\");</script>|", bm.AllScripts.ToString());
        }

        [TestMethod()]
        public void ArrangeHtmlTest()
        {
            Assert.AreEqual(22, bm.LineQueue.Count);
        }

        [TestMethod()]
        public void LinkTest()
        {
            Assert.AreEqual(false, bm.LinkCollection.TotalLinkCount > 20);
        }
    }
}