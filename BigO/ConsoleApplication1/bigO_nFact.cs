using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_nFact
    {
        /// <summary>
        /// O(n!) หรือ factorial
        /// ชนิดสุดท้ายที่ยกมาในวันนี้เรียกได้ว่าเลวร้ายที่สุดสำหรับ BigO
        /// </summary>
        /// <param name="n"></param>
        static void factorialCheck(int n)
        {
            for (int i = 1; i <= factorial(n); i++)
            {
                Console.WriteLine("factorialCheck : " + i);
            }
        }
        static double factorial(int n)
        {
            double f = 1.0;
            for (int k = 2; k <= n; k++)
            {
                f = f * k;
            }
            return f;
        }

        static int nFacRuntime(int n)
        {
            int result = 0;
            if (n == 1) result = 1;
            else for (int i = 0; i < n; i++) { result = nFacRuntime(n - 1); }

            return result;
        }

    }
}
