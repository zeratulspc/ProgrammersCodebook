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
            //return 2;
            Console.WriteLine("answer : "+Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } }));

            //return 1;
            Console.WriteLine("answer : " + Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } }));

            //return 3
            Console.WriteLine("answer : " + Network.Network_Solution(4, new int[4, 4] { { 1, 1, 0, 0 }, { 1, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1} }));

            //return 2
            Console.WriteLine("answer : " + Network.Network_Solution(4, new int[4, 4] { { 1, 1, 1, 0 }, { 1, 1, 0, 0 }, { 1, 0, 1, 0 }, { 0, 0, 0, 1 } }));

            //return 1
            Console.WriteLine("answer : " + Network.Network_Solution(4, new int[4, 4] { { 1, 1, 1, 0 }, { 1, 1, 0, 0 }, { 1, 0, 1, 1 }, { 0, 0, 1, 1 } }));

        }
    }
}
