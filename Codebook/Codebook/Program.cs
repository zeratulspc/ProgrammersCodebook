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
            Console.WriteLine(Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } }));

            //return 1;
            Console.WriteLine(Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } }));
        }
    }
}
