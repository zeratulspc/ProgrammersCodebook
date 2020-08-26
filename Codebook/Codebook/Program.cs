﻿using System;
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

            Console.WriteLine("");
            //1
            Console.WriteLine(new Traffic().Solution(new string[]
            {
                "2016-09-15 01:00:04.001 2.0s",
                "2016-09-15 01:00:07.000 2s"
            }));
            //2
            Console.WriteLine(new Traffic().Solution(new string[]
            {
                "2016-09-15 01:00:04.002 2.0s",
                "2016-09-15 01:00:07.000 2s"
            }));
            //7
            Console.WriteLine(new Traffic().Solution(new string[]
            {
                "2016-09-15 20:59:57.421 0.351s",
                "2016-09-15 20:59:58.233 1.181s",
                "2016-09-15 20:59:58.299 0.8s",
                "2016-09-15 20:59:58.688 1.041s",
                "2016-09-15 20:59:59.591 1.412s",
                "2016-09-15 21:00:00.464 1.466s",
                "2016-09-15 21:00:00.741 1.581s",
                "2016-09-15 21:00:00.748 2.31s",
                "2016-09-15 21:00:00.966 0.381s",
                "2016-09-15 21:00:02.066 2.62s"
            }));

            ////return 2
            //Console.WriteLine("answer : " + Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } }));

            ////return 1
            //Console.WriteLine("answer : " + Network.Network_Solution(3, new int[3, 3] { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } }));

            //return 4
            //Console.WriteLine("answer : " + Network.Network_Solution(8, new int[8, 8] {
            //    { 1,1,0,0,0,0,0,0 }, { 1,1,0,0,0,1,0,0 },
            //    { 0,0,1,1,0,0,0,0 }, { 0,0,1,1,0,0,0,0 },
            //    { 0,0,0,0,1,1,0,0 }, { 0,1,0,0,1,1,0,0 },
            //    { 0,0,0,0,0,0,1,1 }, { 0,0,0,0,0,0,1,1 }
            //}));

            ////return 4
            //Console.WriteLine("answer : " + WordTransition.Word_solution("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }));

            ////return 0
            //Console.WriteLine("answer : " + WordTransition.Word_solution("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }));

        }
    }
}
