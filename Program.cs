using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangevalues
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            x = x * y; 
            y = x / y;
            x = x / y;
            Console.WriteLine("After swaping:"+ " x = " + x + ", y = " + y);
            Console.ReadLine();
        }
    }
}
