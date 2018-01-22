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
    public class SinaPwdEncoderTests
    {
        [TestMethod()]
        public void encodeTest()
        {
            SinaPwdEncoder.encode("123456",LoginHelper.GetServerTime().ToString(), LoginHelper.MakeNonce());
        }
    }
}