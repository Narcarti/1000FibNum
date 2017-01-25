using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1000FibNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibcnt = 1;
            BigInteger fnum = 0;
            BigInteger snum = 1;
            BigInteger fibnum = 0;

            while(fibnum.ToString().Length != 1000)
            {
                fibnum = fnum + snum;
                fnum = snum;
                snum = fibnum;

                fibcnt++;
            }
            Console.WriteLine(fibnum);
            Console.WriteLine(fibcnt);
            Console.ReadKey();
        }
    }
}
