using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_n3
    {
        /// <summary>
        /// O(n³) หรือ cubic
        /// ช้ามาก การเพิ่มขนาด input เข้ามาสองเท่า จะทำให้ระยะเวลาเพิ่มขึ้น แปดเท่า
        /// </summary>
        /// <param name="n"></param>
        static void cubic(int n)
        {
            for (int i = 1; i <= n; i++)
            {// O(n)
                for (int j = 1; j <= n; j++)
                {// O(n)
                    for (int k = 1; k <= n; k++)
                    {// O(n)
                        Console.WriteLine("I: " + i + " J: " + j + " K: " + k);
                    }
                }
            }
        }
    }
}
