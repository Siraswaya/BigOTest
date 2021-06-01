using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_logn
    {
        /// <summary>
        /// O(log n) → Logarithmic Time
        /// Ex.1.O(log n) : logarithmic (จะตัดจำนวนข้อมูลที่ไม่มีโอกาสเกิดขึ้นออกไปทีละครึ่งนึง)
        /// ที่เราใช้กันจริงๆ บ่อยๆ ก็คือ binary search
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int twoDivides(int x)
        {
            int count = 0;
            while (x > 1)
            {
                x = x / 2;
                count = count + 1;
            }
            return count;
           
        }

        /// <summary>
        /// Ex.2
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        static int binarySearch(int[] arr, int value, int first, int last)
        {
            int mid = 0;
            if (last >= first)
            {
                mid = first + (last - first); //2
                if (arr[mid] == value) return mid;              
                else if (arr[mid] > value)  return binarySearch(arr, value, first, mid - 1);
                else return binarySearch(arr, value, mid + 1, last);
            }
            else return -1;

        }

    }
}
