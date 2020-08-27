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

        }
    }
}
