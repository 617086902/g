using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Tests
{
    [TestClass()]
    public class RandomOperateTests
    {
        [TestMethod()]
        public void RandomNameTest()
        {
            RandomOperate.RandomName(7);
        }
    }
}