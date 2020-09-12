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

                this.startTime = endTime - l + 0.001;
            }
        }

        public int Solution(string[] lines)
        {
            List<Times> times = new List<Times>();
            int answer = 0;
            // 파싱
            foreach (var i in lines)
            {
                string[] parsed_t = new string[3];
                string parsed_l = i.Split(' ')[2].Split('s')[0];
                parsed_t = i.Split(' ')[1].Split(':');
                times.Add(new Times(
                    int.Parse(parsed_t[0]),
                    int.Parse(parsed_t[1]),
                    double.Parse(parsed_t[2]),
                    double.Parse(parsed_l))
                );
            }

            foreach (var i in times)
            {
                Console.WriteLine(i.startTime+" "+i.endTime);
            }
            
            int[] countPoint = new int[times.Count];
            for (int i = 0; i < times.Count; i++)
            {
                countPoint[i] = 0;
                double s = times[i].startTime;
                double e = s + 1;
                for (int j = 0; j < times.Count; j++)
                {
                    if (times[j].startTime >= s && times[j].startTime < e)
                    {
                        countPoint[i]++;
                        //Console.WriteLine("[i:" + i + "][j:" + j + "]p:" + countPoint[i] + " s:" + s + " e:" + e);
                    }
                    else if (times[j].endTime >= s && times[j].endTime < e)
                    {
                        countPoint[i]++;
                        //Console.WriteLine("[i:" + i + "][j:" + j + "]p:" + countPoint[i] + " s:" + s + " e:" + e);
                    }
                    else if (times[j].startTime <= s && times[j].endTime >= e)
                    {
                        countPoint[i]++;
                        //Console.WriteLine("[i:" + i + "][j:" + j + "]p:" + countPoint[i] + " s:" + s + " e:" + e);
                    }
                }
            }

            foreach (var i in countPoint) 
            {
                if (i > answer)
                {
                    answer = i;
                }
            }

            for (int i = 0; i < times.Count; i++)
            {
                countPoint[i] = 0;
                double s = times[i].endTime;
                double e = s + 1;

                for (int j = 0; j < times.Count; j++)
                {
                    if (times[j].startTime >= s && times[j].startTime < e)
                    {
                        countPoint[i]++;
                        //Console.WriteLine("[i:" + i + "][j:" + j + "]p:" + countPoint[i] + " s:" + s + " e:" + e);
                    }
                    else if (times[j].endTime >= s && times[j].endTime < e)
                    {
                        countPoint[i]++;
                        //Console.WriteLine("[i:" + i + "][j:" + j + "]p:" + countPoint[i] + " s:" + s + " e:" + e);
                    }
                    else if (times[j].startTime <= s && times[j].endTime >= e)
                    {
                        countPoint[i]++;
                        //Console.WriteLine("[i:"+i+"][j:"+j+"]p:"+countPoint[i]+" s:"+s+" e:"+e);
                    }
                }
            }

            foreach (var i in countPoint)
            {
                if (i > answer)
                {
                    answer = i;
                }
            }
            return answer;
        }
    }
}