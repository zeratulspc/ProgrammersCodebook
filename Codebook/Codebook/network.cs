using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        네트워크란 컴퓨터 상호 간에 정보를 교환할 수 있도록 연결된 형태를 의미합니다.
        예를 들어, 컴퓨터 A와 컴퓨터 B가 직접적으로 연결되어있고, 
        컴퓨터 B와 컴퓨터 C가 직접적으로 연결되어 있을 때 컴퓨터 A와 컴퓨터 C도 간접적으로 연결되어 정보를 교환할 수 있습니다
        .따라서 컴퓨터 A, B, C는 모두 같은 네트워크 상에 있다고 할 수 있습니다.

        컴퓨터의 개수 n, 연결에 대한 정보가 담긴 2차원 배열 computers가 매개변수로 주어질 때, 
        네트워크의 개수를 return 하도록 solution 함수를 작성하시오.


        제한사항
        컴퓨터의 개수 n은 1 이상 200 이하인 자연수입니다.
        각 컴퓨터는 0부터 n-1인 정수로 표현합니다.
        i번 컴퓨터와 j번 컴퓨터가 연결되어 있으면 computers[i][j] 를 1로 표현합니다.
        computer[i][i] 는 항상 1입니다.
*/

namespace Codebook
{
    public class Network
    {

        public struct Line
        {
            public int parent;
            public int child;
            public Line(int a, int b)
            {
                parent = a;
                child = b;
            }
        }

        public static int Network_Solution(int n, int[,] computers)
        {
            int answer = 0;
            List<Line> lines = new List<Line>();
            for (int c = 0; c < computers.GetLength(1);c++) //computers[r, c] row, column
            { //TODO : 3개 이상 연결된 네트워크도 고려할 것
                bool isIndipendent = true;
                for (int r = 0; r < computers.GetLength(0); r++)
                {
                    if (r != c)
                    {
                        if (computers[r, c] == 1)
                        {
                            Console.WriteLine("[Add]row : "+r+" column : "+c);
                            lines.Add(new Line(c, r));
                            isIndipendent = false;
                            if (lines.Contains(new Line(r, c)))
                            {
                                int idx = lines.IndexOf(new Line(c, r));
                                Console.WriteLine("[remove#1]row : " + lines[idx].child + " column : " + lines[idx].parent);
                                lines.RemoveAt(idx);
                            }

                            if (isIndipendent)
                            {
                                Console.WriteLine("[Indipendent]row : " + r+" column :"+c);
                            }
                        }
                    }
                }

                if (isIndipendent)
                {
                    answer++;
                }
            }

            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 0; j < lines.Count; j++)
                {
                    if (lines.Count != 1)
                    {
                        if (lines[i].parent == lines[j].parent || lines[i].child == lines[j].child)
                        {
                            Console.WriteLine("[remove#2]row : " + lines[i].child + " column : " + lines[i].parent);
                            lines.RemoveAt(i);
                        }
                    }
                }
            }
            lines.ForEach(delegate (Line v) {
                Console.WriteLine("[Result]"+v.parent + "-" + v.child);
            });
            answer += lines.Count;
            return answer;
        }

    }
}
