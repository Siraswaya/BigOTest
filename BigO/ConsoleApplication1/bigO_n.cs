using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bigO_n
    {
        /// <summary>
        /// O(n) → Linear Time
        /// Big O = O(n) : linear (ระยะเวลาขึ้นอยู่กับจำนวน input)
        /// Call function by : bigO_n_itemInList(2, [1,2,3]);
        /// </summary>
        /// <param name="check"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        static bool bigO_n_itemInList(int check, int[] list)
        {
            for (var i = 0; i < list.Length; i++)
            {
                if (list[i] == check) return true;
            }
            return false;
        }
    }
}
