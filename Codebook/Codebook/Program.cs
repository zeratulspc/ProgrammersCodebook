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
            ////return 2
            //Console.WriteLine("answer : "+Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } }));

            ////return 1
            //Console.WriteLine("answer : " + Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } }));

            //return 4
            Console.WriteLine("answer : " + Network.Network_Solution(8, new int[8, 8] { 
                { 1,1,0,0,0,0,0,0 }, { 1,1,0,0,0,0,0,0 },
                { 0,0,1,1,0,0,0,0 }, { 0,0,1,1,0,0,0,0 },
                { 0,0,0,0,1,1,0,0 }, { 0,0,0,0,1,1,0,0 },
                { 0,0,0,0,0,0,1,1 }, { 0,0,0,0,0,0,1,1 }
            }));

            //return 4
            //Console.WriteLine("answer : "+WordTransition.Word_solution("hit","cog",new string[] { "hot", "dot", "dog", "lot", "log", "cog"}));

            //return 0
            //Console.WriteLine("answer : " + WordTransition.Word_solution("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log"}));

        }
    }
}
