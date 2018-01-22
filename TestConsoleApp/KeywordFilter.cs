using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class KeywordFilter
    {
        private HashSet<string> bwSet;
        private BitArray firstChatCheck = new BitArray(char.MaxValue);
        private BitArray allChatCheck = new BitArray(char.MaxValue);
        private int maxlength = 0;
        public KeywordFilter()
        {
            string allTxt = FileHelper.ReadAll(AppDomain.CurrentDomain.BaseDirectory+"\\bad.txt");
            string[] badwords = allTxt.Trim().Split('|');
            bwSet = new HashSet<string>();
            foreach (var word in badwords)
            {
                if (bwSet.Contains(word)) continue;
                bwSet.Add(word);
                firstChatCheck[word[0]] = true;
                maxlength = Math.Max(maxlength, word.Length);
                foreach (var c in word) allChatCheck[c] = true;
            }
        }
        public bool ContainsBadwords(string words)
        {
            int index = 0;
            while (index < words.Length)
            {
                if (!firstChatCheck[words[index]]) while (index < words.Length - 1 && !firstChatCheck[words[++index]]) ;
                for (int j = 1; j <= Math.Min(maxlength, words.Length - index); j++)
                {
                    if (!allChatCheck[words[index + j - 1]]) break;
                    string substr = words.Substring(index, j);
                    if (bwSet.Contains(substr)) return true;
                }
                index++;
            }
            return false;
        }
        public string Filtering(string words)
        {
            if (!ContainsBadwords(words)) return words;

            int index = 0;
            int rindex;//防止重叠词输入，例如皇皇军军
            while (index < words.Length)
            {
                rindex = index;
                if (!firstChatCheck[words[index]]) while (index < words.Length - 1 && !firstChatCheck[words[++index]]) ;
                for (int j = 1; j <= Math.Min(maxlength, words.Length - index); j++)
                {
                    if (!allChatCheck[words[index + j - 1]]) break;
                    string substr = words.Substring(index, j);
                    if (bwSet.Contains(substr))
                    {
                        words = words.Replace(substr, "");
                        rindex = rindex - 1 < 0 ? 0 : rindex - 1;
                        break;
                    }
                }
                index = rindex == index ? index + 1 : rindex;
            }
            return words;
        }
    }
}
