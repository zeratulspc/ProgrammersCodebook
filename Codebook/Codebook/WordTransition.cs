using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebook
{
    class WordTransition
    {
        public static int Word_solution(string begin, string target, string[] words)
        {
            int answer = 0;

            for (int i = 0; i < words.Length; i++)
            {
                int changeCount = 0;
                Console.WriteLine("[" + words[i] + "]");
                for (int j = 0; j < words[i].Count(); j++)
                {
                    if (!(changeCount > 1))
                    {
                        if (begin[j] != words[i][j])
                        {
                            Console.Write(words[i][j]);
                            changeCount++;
                        }
                    }
                }
                Console.WriteLine("");
                if (!(changeCount > 1))
                {
                    begin = words[i];
                    if (begin == target)
                        break;
                    answer++;
                }
            }

            if (!words.Contains(target))
                answer = 0;
            return answer;
        }

    }
}
