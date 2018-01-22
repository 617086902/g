using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TF.BitterMelon;
using TF.BitterMelon.AnalogLogin.SinaWeibo;
using TF.BitterMelon.Tool;

namespace ConsoleApp
{
    class Program
    {
        static int index = 0;
        public static void Main(string[] args)
        {


            //微生活红包测试
            //HttpHelper hh = new HttpHelper();
            //HttpItem item = new HttpItem
            //{
            //    URL = "http://xgege.vicp.cc/m/hongbao/hongbao_receive_test/id/75",
            //    Method = "GET",
            //};
            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        int cindex = index++;
            //        var amount = hh.GetHtml(item).Html;
            //        if (amount != "-1")
            //        {
            //            Console.WriteLine("第“" + cindex + "”个红包抢红包成功:" + amount);
            //        }
            //        else
            //        {
            //            Console.WriteLine("第“" + cindex + "”个红包抢红包失败:" + amount);
            //        }
            //    });
            //}

            //测试每秒执行次数
            //var dtn = DateTime.Now;
            //int index = 0;
            //int lindex = 0;
            //while (true)
            //{
            //    index++;
            //    if (DateTime.Now.AddSeconds(-1).Second == dtn.Second)
            //    {
            //        dtn = DateTime.Now;
            //        Console.WriteLine(index + "--" + (index - lindex));
            //        lindex = index;
            //    }
            //}


            //Test1.Gooooooo();
            //for(int i = 0; i < 100000; i++)
            //{
            //    string a = "1";
            //}
            Console.ReadKey();
            //forU.l();
            //IList<string> list = RestoreIpAddresses("25525511135");
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        private static ListNode RotateRight(ListNode head, int k)
        {
            return null;
        }

        private static IList<string> RestoreIpAddresses(string s)
        {
            List<string> arr = new List<string>();
            if (s.Length >= 13 || s.Length <= 3) return arr;
            int minVal = 0, maxVal = 255, minLen = 1, maxLen = 3;
            for (int a = minLen; a <= maxLen; a++)
            {
                for (int b = minLen; b <= maxLen; b++)
                {
                    for (int c = minLen; c <= maxLen; c++)
                    {
                        for (int d = minLen; d <= maxLen; d++)
                        {
                            int h, i, j, k;
                            if (a + b + c + d != s.Length) continue;
                            string s1 = s.Substring(0, a), s2 = s.Substring(a, b), s3 = s.Substring(a + b, c), s4 = s.Substring(a + b + c, d);
                            if (s1 != "0" && s1.TrimStart('0') != s1) continue;
                            if (s2 != "0" && s2.TrimStart('0') != s2) continue;
                            if (s3 != "0" && s3.TrimStart('0') != s3) continue;
                            if (s4 != "0" && s4.TrimStart('0') != s4) continue;
                            int.TryParse(s1, out h);
                            int.TryParse(s2, out i);
                            int.TryParse(s3, out j);
                            int.TryParse(s4, out k);
                            if (h < minVal || h > maxVal || i < minVal || i > maxVal || j < minVal || j > maxVal || k < minVal || k > maxVal) continue;
                            string ip = string.Format("{0}.{1}.{2}.{3}", h, i, j, k);
                            if (!arr.Contains(ip)) arr.Add(ip);
                        }
                    }
                }
            }
            return arr;
        }

        #region melon
        private static void Melon()
        {
            BitterMelon bm = new BitterMelon(new Uri("http://www.nichaogu.com/p/57"));
            foreach (var line in bm.GetMergedLineQueue())
            {
                Console.WriteLine(line.LineStr);
            }
            Console.Read();
        }
        #endregion

        #region 敏感词过滤
        private static void KwFilter(string words)
        {
            KeywordFilter kf = new KeywordFilter();
            string goodword = kf.Filtering(words);
            Console.WriteLine(goodword);
            Console.Read();
        }
        #endregion

        #region 事件委托

        public delegate void checkDelegate();
        public event checkDelegate checkEvent;
        private static void Delegatettttt()
        {
            call objcall;
            DelegateTest dtest = new DelegateTest();
            objcall = new call(dtest.multiply);
            //objcall += new call(dtest.divide);
            Console.WriteLine(objcall(6, 6));
            objcall = delegate (int a, int b) { return a + b; };
            Console.WriteLine(objcall(1, 2));
            objcall = (int a, int b) => { return a - b; };
            Console.WriteLine(objcall(100, 50));
            Func<int, int, int> objFunc = (int a, int b) => { return a + b; };

            Console.WriteLine(objFunc(10, 20));
            Console.WriteLine("==============");
        }
        #endregion

        public static void lambdaTest()
        {
            ParameterExpression ei = Expression.Parameter(typeof(int), "i");
            ParameterExpression ej = Expression.Parameter(typeof(int), "j");
            BinaryExpression em = Expression.Multiply(ei, ej);
            Expression<Func<int, int, int>> lambda = Expression.Lambda<Func<int, int, int>>(em, ei, ej);
            Func<int, int, int> f = lambda.Compile();
            Console.WriteLine(f(10, 12));
        }
    }
}
