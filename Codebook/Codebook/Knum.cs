using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebook
{
    public class Knum
    {
        public int[] Solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] _arr = new int[(commands[i, 1] - commands[i, 0]) + 1];
                int a = 0;
                for (int j = commands[i, 0]-1; j<commands[i,1];j++) 
                {
                    _arr[a] = array[j];
                    a++;
                }

                Array.Sort(_arr);
                answer[i] = _arr[commands[i, 2] - 1];
            }

            return answer;
        }
    }
}
