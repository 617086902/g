using Microsoft.VisualStudio.TestTools.UnitTesting;
using TF.BitterMelon.AnalogLogin.SinaWeibo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.BitterMelon.AnalogLogin.SinaWeibo.Tests
{
    [TestClass()]
    public class LoginHelperTests
    {
        [TestMethod()]
        public void EncodeAccountTest()
        {
            LoginHelper.EncodeAccount("13269276932");
        }
    }
}