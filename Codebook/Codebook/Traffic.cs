using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

/*
try 1 : 1
    "2016 - 09 - 15 01:00:04.001 2.0s",
    "2016 - 09 - 15 01:00:07.000 2s"
try 2 : 2
    "2016-09-15 01:00:04.002 2.0s",
    "2016-09-15 01:00:07.000 2s"
try 3 : 7
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
*/


namespace Codebook
{
    class Traffic
    {
        public struct Times
        {
            public double startTime;
            public double endTime;

            public Times(int h, int m, double s, double l)
            {
                this.endTime = 0;
                this.endTime += h * 3600;
                this.endTime += m * 60;
                this.endTime += s;
                this.endTime = Math.Round(this.endTime * 10000) / 10000;

                this.startTime = endTime - l;
                this.startTime = Math.Round(this.startTime * 10000) / 10000;
            }
        }

        public int Solution(string[] lines)
        {
            List<Times> times = new List<Times>();

            // 파싱
            foreach (var i in lines)
            {
                string[] parsed_t = new string[3];
                string parsed_l = i.Split(' ')[2].Split('s')[0];
                parsed_t = i.Split(' ')[1].Split(':');
                times.Add(new Times(
                    int.Parse(parsed_t[0]),
                    int.Parse(parsed_t[1]),
                    float.Parse(parsed_t[2]),
                    float.Parse(parsed_l))
                );
            }
            double low = 1000000000;
            double high = 0;

            foreach (var i in times)
            {
                if (i.startTime < low)
                {
                    low = i.startTime;
                }
                if (i.endTime > high)
                {
                    high = i.endTime;
                }
            }

            int count = (int)(high - low);
            int[] countPoint = new int[count];
            for (int i = 0; i < count; i++)
            {
                countPoint[i] = 0;
                int s = (int)(low + i);
                int e = (int)(s + 1);
                Console.WriteLine("s : " + s + " e : " + e);
                for (int j = 0; j < times.Count; j++)
                {
                    if (times[j].startTime <= s)
                    {
                        if (times[j].endTime >= s)
                        {
                            countPoint[i]++;
                        }
                    }
                    else if (times[j].startTime >= s)
                    {
                        if (times[j].startTime <= e)
                        {
                            countPoint[i]++;
                        }
                    }
                    Console.WriteLine("j : " + j + " countPoint : " + countPoint[i] + " Starttime : " + times[j].startTime + " EndTime : " + times[j].endTime);
                }
                Console.WriteLine("i : " + i + " countPoint : " + countPoint[i]);
            }

            foreach (var i in countPoint)
            {
                Console.WriteLine(i);
            }

            int answer = 1000000000;
            return answer;
        }
    }
}
