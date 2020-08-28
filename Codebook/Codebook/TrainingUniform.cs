using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebook
{
    class TrainingUniform
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = n - lost.Length;

            Array.Sort(lost);

            // lost - reserve 중복 검사
            for (int i = 0; i < lost.Length; i++)
            {
                for (int j = 0; j < reserve.Length; j++)
                {
                    if (lost[i] == reserve[j])
                    {
                        reserve[j] = 50;
                        break;
                    }
                }
            }

            // 메인 테스트
            for (int i=0;i<lost.Length;i++)
            {
                for (int j=0;j<reserve.Length;j++)
                {
                    if (reserve[j] != 50)
                    {
                        if (lost[i] == reserve[j] + 1 || lost[i] == reserve[j] - 1)
                        {
                            reserve[j] = 50;
                            answer++;
                            break;
                        }
                    }
                }
            }
                return answer;
        }
    }
}
