using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// O(1) → Constant Time
    /// Big O = O(1) = 1 เพราะไม่มี loop อะไรเลย
    /// </summary>
    public class bigO_1
    {
        /// <summary>
        /// Ex.1 returnItem(item)
        /// Call function by : bigO_1_returnItem(2); 
        /// </summary>
        public int bigO_1_returnItem(int item)
        {
            return item;
        }

        /// <summary>
        /// Ex.2 Check Odd & Even
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int bigO_1_evenOrOdd(int num)
        {
            if (num % 2 == 0) Console.WriteLine("Evne : " + num);
            else Console.WriteLine("Odd : " + num);
            return num;
        }

    }
}
