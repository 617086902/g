using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class MultiTreeTests
    {
        [TestMethod()]
        public void AddTest()
        {
            TreeNode head = null;
            MultiTree.Add(ref head, 0, 1, "one");
            MultiTree.Add(ref head, 1, 2, "two");
            MultiTree.Add(ref head, 1, 3, "three");
            MultiTree.Add(ref head, 2, 4, "four");
        }
    }
}