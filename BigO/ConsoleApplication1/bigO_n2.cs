using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_n2
    {
        /// <summary>
        /// O(n²) → Quadratic Time
        /// Ex.1 : O(n²) หรือ quadratic 
        /// มี 2-nested loop
        /// ประสิทธิภาพช้า การเพิ่มขนาด input เข้ามาสองเท่า จะทำให้ระยะเวลาเพิ่มขึ้น สี่เท่า
        /// </summary>
        /// <param name="n"></param>
        static void qudratic(int n)
        {
            for (int i = 1; i <= n; i++)
            {// O(n)
                for (int j = 1; j <= n; j++)
                {// O(n)
                    Console.WriteLine("I: " + i + " J: " + j);
                }
            }
        }

        /// <summary>
        /// Ex.2
        /// </summary>
        /// <param name="list"></param>
        static void allCombos(int[] list)
        {
            int[] results = { 1, 2, 3 };
            for (var i = 0; i < results.Length; i++)
            {// O(n)
                for (int j = 0; j < results.Length; j++)
                {// O(n)
                    Console.WriteLine(results[i].ToString());

                }
            }
        }
    }
}
