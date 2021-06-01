using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_nlogn
    {
        /// <summary>
        /// Ex.1 O(n log n) หรือ linearithmic
        /// เป็นการวนลูปสองรอบ ลูปชั้นนอกวนแบบปกติ (n รอบ) แต่ลูปชั้นในวนแบบตัดข้อมูลที่ไม่เกี่ยวข้องออกไปทีละครึ่งด้วย (log n)
        /// ตัวอย่างที่ใช้กันจริง ก็เช่น Merge Sort, Heap Sort หรือ Quick Sort
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int[] nlogn(int n)
        {
            int[] results = { 3, 1, 3, 1, 3, 1 };
            for (int i = 0; i < n; i++)
            { // this loop is executed n times, so O(n)
                for (int j = n; j > 0; j = (j / 2))
                { // this loop is executed log(n) times, so O(logn)
                    Console.WriteLine("j : " + j);
                }
            }
            return results;
        }

        /// <summary>
        /// Ex.2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int[] nlogn2(int n)
        {
            int[] results = { 3, 1, 3, 1, 3, 1 };
            for (int i = 0; i < n; i++)
            { // this loop is executed n times, so O(n)
                for (int j = n; j > 0; j = (j / 2))
                { // this loop is executed log(n) times, so O(logn)
                    Console.WriteLine("j : " + j);
                }
            }
            return results;
        }
    }
}
