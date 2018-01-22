using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.BitterMelon.Tool;

namespace TF.BitterMelon.AnalogLogin.SinaWeibo
{
    public class SinaPwdEncoder
    {
        private static bool i = false;
        private static int g = 8;
        
        public static String encode(String psw, String servertime, String nonce)
        {
            String password;
            password = hex_sha1("" + hex_sha1(hex_sha1(psw)) + servertime + nonce);
            return password;
        }

        private static String hex_sha1(string j)
        {
            return h(b(f(j, j.Length * g), j.Length * g));
        }
        private static String h(int[] l)
        {
            String k = i ? "0123456789ABCDEF" : "0123456789abcdef";
            String m = "";
            for (int j = 0; j < l.Length * 4; j++)
            {
                m += StringHelper.CharAt(k, (l[j >> 2] >> ((3 - j % 4) * 8 + 4)) & 15) + "" + StringHelper.CharAt(k, (l[j >> 2] >> ((3 - j % 4) * 8)) & 15);
            }
            return m;
        }

        private static int[] b(int[] A, int r)
        {
            A[r >> 5] |= 128 << (24 - r % 32);
            A[((r + 64 >> 9) << 4) + 15] = r;
            int[] B = new int[80];
            int z = 1732584193;
            int y = -271733879;
            int v = -1732584194;
            int u = 271733878;
            int s = -1009589776;
            for (int o = 0; o < A.Length; o += 16)
            {
                int q = z;
                int p = y;
                int n = v;
                int m = u;
                int k = s;
                for (int l = 0; l < 80; l++)
                {
                    if (l < 16)
                    {
                        B[l] = A[o + l];
                    }
                    else
                    {
                        B[l] = d(B[l - 3] ^ B[l - 8] ^ B[l - 14] ^ B[l - 16], 1);
                    }
                    int C = e(e(d(z, 5), a(l, y, v, u)), e(e(s, B[l]), c(l)));
                    s = u;
                    u = v;
                    v = d(y, 30);
                    y = z;
                    z = C;
                }
                z = e(z, q);
                y = e(y, p);
                v = e(v, n);
                u = e(u, m);
                s = e(s, k);
            }
            return new int[] { z, y, v, u, s };
        }

        private static int a(int k, int j, int m, int l)
        {
            if (k < 20) { return (j & m) | ((~j) & l); };
            if (k < 40) { return j ^ m ^ l; };
            if (k < 60) { return (j & m) | (j & l) | (m & l); };
            return j ^ m ^ l;
        }
        private static int c(int j)
        {
            return (j < 20) ? 1518500249 : (j < 40) ? 1859775393 : (j < 60) ? -1894007588 : -899497514;
        }
        private static int e(int j, int m)
        {
            int l = (j & 65535) + (m & 65535);
            int k = (j >> 16) + (m >> 16) + (l >> 16);
            return (k << 16) | (l & 65535);
        }
        private static int d(int j, int k)
        {
            return (j << k) | Foo(j, (32 - k));
        }

        private static int[] f(String m, int r)
        {
            int[] l;
            int j = (1 << g) - 1;
            int len = ((r + 64 >> 9) << 4) + 15;
            int k;
            for (k = 0; k < m.Length * g; k += g)
            {
                len = k >> 5 > len ? k >> 5 : len;
            }
            l = new int[len + 1];
            for (k = 0; k < l.Length; k++)
            {
                l[k] = 0;
            }
            for (k = 0; k < m.Length * g; k += g)
            {
                l[k >> 5] |= (Convert.ToChar(StringHelper.CharAt(m, k / g)) & j) << (24 - k % 32);
            }
            return l;
        }
        private static int Foo(int x, int y)
        {
            int mask = 0x7fffffff; //Integer.MAX_VALUE
            for (int i = 0; i < y; i++)
            {
                x >>= 1;
                x &= mask;
            }
            return x;
        }
    }
}
