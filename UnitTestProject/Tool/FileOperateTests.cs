using Microsoft.VisualStudio.TestTools.UnitTesting;
using TF.BitterMelon.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.Tool.Tests
{
    [TestClass()]
    public class FileOperateTests
    {
        [TestMethod()]
        public void WriteFileTest()
        {
            FileOperate.WriteFile(AppDomain.CurrentDomain.BaseDirectory + "\\abc.txt", "tesfasdfasdft");
        }
    }
}