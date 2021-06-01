using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BigO
    {
        static void Main(string[] args)
        {

            //Name Big O
            //====Constant      O(1)
            //====Linear        O(n)
            //====Quadratic     O(n^2)
            //====Cubic         O(n^3)
            //====Exponential   O(2^n)
            //====Logarithmic   O(log(n))
            //====Log Linear    O(nlog(n))
            //====Factorial    O(n!)


            //  O(1)    
            //  O(log(n))
            //  O(n)      
            //  O(nlog(n))
            //  O(n^2)
            //  O(2^n)
            //  O(n!)
            

            int number = 22; ;
            int[] numArray = { 1, 2, 7, 10, 22, 31, 30 };

            //O(1)
            String resultO1 = bigO_1_evenOrOdd(5);
            Console.WriteLine("O(1) result : " + resultO1);

            //O(n)
            int[] numArrayOn = { 1, 2, 7, 10, 22, 31, 30 };
            bool resultOn = false;
            resultOn = bigO_n_itemInList(7, numArrayOn);
            Console.WriteLine("O(n) result : " + resultOn);

            //O(n²)
            int[] numArrayOn2 = { 1, 2, 7, 10, 22, 31, 30 };
            String resultOn2 =allCombos(numArrayOn2);
            Console.WriteLine("O(n²) result : " + resultOn2);

            //O(2^n)
            int result2n=fib(5);
            Console.WriteLine("O(2^n) result : " + result2n);

            //O(log n) Ex1
            int resultLogN1 = twoDivides(9);
            Console.WriteLine("O(log n) result 1 : " + resultLogN1);
            
            //nlogn
            int resultNLogN = nlogn(9);
            Console.WriteLine("nlogn result : " + resultNLogN);

            //O(n!)
            int resultNFact = factorialCheck(6);
            Console.WriteLine("O(n!) result : " + resultNFact);

            Console.ReadKey();

        }

        //=============== O(1) =================================================================================================
        /// O(1) → Constant Time
        /// Big O = O(1) = 1 เพราะไม่มี loop อะไรเลย

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
        static String bigO_1_evenOrOdd(int num)
        {
            String result = "";
            if (num % 2 == 0) result = "Even";
            else result = "Odd";
            return result;
        }
        //============== O(n) ==================================================================================================
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
        //=============== O(n²) =================================================================================================
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
        static String allCombos(int[] list)
        {           
            String result = "";
            for (var i = 0; i < list.Length; i++)
            {// O(n)
                for (int j = 0; j < list.Length; j++)
                {// O(n)
                    Console.WriteLine(list[i].ToString());
                    result= list[i].ToString();

                }
            }
            return result;
        }

        //========== O(n³) ======================================================================================================
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
        //=========== O(2^n) =====================================================================================================
        /// <summary>
        /// O(2^n) หรือ exponential
        /// เลวร้าย การเพิ่มขนาดของ input แค่นิดเดียว ก็ทำให้ระยะเวลาในการประมวลผลเพิ่มขึ้นแบบมหาศาล
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int fib(int number)
        {
            if (number <= 1) return number;
            else return fib(number - 2) + fib(number - 1);
        }
        //============ O(log n) ====================================================================================================
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
                else if (arr[mid] > value) return binarySearch(arr, value, first, mid - 1);
                else return binarySearch(arr, value, mid + 1, last);
            }
            else return -1;

        }
        //============ O(n log n) ====================================================================================================
        /// <summary>
        /// Ex.1 O(n log n) หรือ linearithmic
        /// เป็นการวนลูปสองรอบ ลูปชั้นนอกวนแบบปกติ (n รอบ) แต่ลูปชั้นในวนแบบตัดข้อมูลที่ไม่เกี่ยวข้องออกไปทีละครึ่งด้วย (log n)
        /// ตัวอย่างที่ใช้กันจริง ก็เช่น Merge Sort, Heap Sort หรือ Quick Sort
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int nlogn(int n)
        {
            int result=0;
            for (int i = 0; i < n; i++)
            { // this loop is executed n times, so O(n)
                for (int j = n; j > 0; j = (j / 2))
                { // this loop is executed log(n) times, so O(logn)
                    result = j;
                }
            }
            return result;
        }

        //============= O(n!) ===================================================================================================
        /// <summary>
        /// O(n!) หรือ factorial
        /// ชนิดสุดท้ายที่ยกมาในวันนี้เรียกได้ว่าเลวร้ายที่สุดสำหรับ BigO
        /// </summary>
        /// <param name="n"></param>
        static int factorialCheck(int n)
        {
            int result = 0;
            for (int i = 1; i <= factorial(n); i++)
            {
                return result=i;
            }
            return result;
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
       
        //================================================================================================================

        //================================================================================================================


        //================================================================================================================


        static void calCulator(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
        


    }
}
