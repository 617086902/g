using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public delegate int call(int n1, int n2);
    public class DelegateTest
    {
        public int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public int divide(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
