using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebook
{
    class TrainingUniform
    {
        public int solution(int pN, int[] pLost, int[] pReserve)
        {
            int answer = 0;
            List<int> lost = new List<int>(pLost);
            List<int> reserve = new List<int>(pReserve);

            for (int i = 0; i<pLost.Length;i++)
            {
                if (reserve.Contains(pLost[i]))
                {
                    reserve.Remove(lost[i]);
                    lost.RemoveAt(i);
                }
                else if (reserve.Contains(pLost[i] - 1))
                {
                    reserve.Remove(lost[i] - 1);
                    lost.RemoveAt(i);
                }
                else if (reserve.Contains(pLost[i] + 1))
                {
                    reserve.Remove(lost[i] + 1);
                    lost.RemoveAt(i);
                }
            }

            Console.WriteLine("------도둑");
            foreach (var i in lost)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("------예비");

            foreach (var i in reserve)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("------결과,");
            answer = pN - lost.Count;
            return answer;
        }
    }
}
