using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Input: "abcabcbb"
//Output: 3 
//Explanation: The answer is "abc", with the length of 3. 

namespace _3.Longest_Substring
{
    public class Slution
    {
        public int LengthOfLongetSubstring(string s)
        {
            List<char> ls = new List<char>();
            int n = s.Length;
            int intMaxLength = 0;

            for (int i = 0; i < n; i++)
            {
                if (ls.Contains(s[i]))
                {
                    //RemoveRange(int, int) 从 List<T> 中移除特定对象的第一个匹配项。
                    //IndexOf(int) 搜索指定的对象，并返回整个 List<T> 中最后一个匹配项的从零开始的索引。
                    ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);
                }

                ls.Add(s[i]);
                intMaxLength = ls.Count > intMaxLength ? ls.Count : intMaxLength;
            }
            return intMaxLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string testSrt = "abcabcbb";
            var s = new Slution();
            Console.WriteLine($"Length of longest substring is {s.LengthOfLongetSubstring(testSrt)}");
            Console.ReadKey();
        }
    }
}
