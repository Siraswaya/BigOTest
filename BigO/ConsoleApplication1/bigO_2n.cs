using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_2n
    {
        static int fib(int number)
        {
            if (number <= 1) return number;
            else return fib(number - 2) + fib(number - 1);
        }
    }
}
