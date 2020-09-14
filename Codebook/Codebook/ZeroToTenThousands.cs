using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebook
{
    public class ZeroToTenThousands
    {
        public void MakeFile() 
        {

            int foo = 0;
            string b = "";
            while (foo <= 99999999) 
            {
                //string 지정 
                string a = String.Format("{0:00000000}\n", foo);
                //메모장에 쓰기
                b += a;
                Console.WriteLine(foo);
                foo++;
            }
            System.IO.File.WriteAllText(@"D:\Works\result\test.txt", b, Encoding.Default);
        }
    }
}
