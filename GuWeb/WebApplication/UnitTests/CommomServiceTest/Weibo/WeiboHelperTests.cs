using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonService.Weibo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.Weibo.Tests
{
    [TestClass()]
    public class WeiboHelperTests
    {
        [TestMethod()]
        public void SaveDataTest()
        {
            WeiboHelper.SaveWeiboStockData();
        }
    }
}