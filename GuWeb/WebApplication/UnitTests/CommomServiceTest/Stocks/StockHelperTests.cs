using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonService.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.Stocks.Tests
{
    [TestClass()]
    public class StockHelperTests
    {
        [TestMethod()]
        public void GetDetialsTest()
        {
            StockHelper.GetDetials("600000");
        }

        [TestMethod()]
        public void GetCurrentStockDataTest()
        {
            StockHelper.GetCurrentStockData("600821");
        }
    }
}