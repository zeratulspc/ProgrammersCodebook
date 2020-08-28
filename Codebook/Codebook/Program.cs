using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Codebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //5
            Console.WriteLine(new TrainingUniform().solution(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 }));
            //4
            Console.WriteLine(new TrainingUniform().solution(5, new int[] { 2, 4 }, new int[] { 3 }));
            //2
            Console.WriteLine(new TrainingUniform().solution(3, new int[] { 3 }, new int[] { 1 }));
            //1
            Console.WriteLine(new TrainingUniform().solution(2, new int[] { 1, 2 }, new int[] { 1, 3 }));


            Console.WriteLine(new TrainingUniform().solution(24, new int[] { 12, 13, 16, 17, 19, 20, 21, 22 }, new int[] { 1, 22, 16, 18, 9, 10 }));

            //solution(5, { 2,4 }, { 1,3,5 });
            //solution(5, { 2,4 }, { 3 });
            //solution(3, { 3 }, { 1 });
            //solution(3, { 1,3 }, { 1,2 });
            //solution(8, { 5,6 }, { 4,5 });
            //solution(3, { 2,3 }, { 1 });//2
            //solution(5, { 3,4 }, { 4,5 });//4
            //solution(18, { 7,8,11,12 }, { 1,6,8,10 });//17
            //solution(24, { 12,13,16,17,19,20,21,22 }, { 1,22,16,18,9,10});//19
            //solution(7, { 2,3,4 }, { 1,2,3,6 });
            //solution(5, { 2,3,4 }, { 3,4,5 });
            //solution(10, { 3,9,10 }, { 3,8,9 });
        }
    }
}
