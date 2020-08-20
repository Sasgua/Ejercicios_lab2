using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond; int dado = (miliseg % 100) + 1;
            Console.Write("El numero del dado es {0} ", dado);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
