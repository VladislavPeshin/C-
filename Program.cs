using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 40;
            int d = c-- - b * a;    // a=3  b=5  c=39  d=25
            Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");
        }
    }
}
