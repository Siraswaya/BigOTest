# BigOTest

### Big O Notation

1. Constant      O(1)
2. Linear        O(n)
3. Quadratic     O(n^2)
4. Cubic         O(n^3)
5. Exponential   O(2^n)
6. Logarithmic   O(log(n))
7. Log Linear    O(nlog(n))
8. Factorial    O(n!)

O(1) >> O(log(n)) >> O(n) >> O(nlog(n)) >> O(n^2) >> O(2^n) >> O(n!)

## O(1) - Constant 
O(1) = 1 เพราะไม่มี loop

      static String bigO_1_evenOrOdd(int num)
        {
            String result = "";
            if (num % 2 == 0) result = "Even";
            else result = "Odd";
            return result;
        }

      static void Main(string[] args)
        {
            String resultO1 = bigO_1_evenOrOdd(5);
            Console.WriteLine("O(1) result : " + resultO1);
            Console.ReadKey();
        }

## O(n) - Linear      
O(n) = ระยะเวลาขึ้นอยู่กับจำนวน input

      static bool bigO_n_itemInList(int check, int[] list)
        {
            for (var i = 0; i < list.Length; i++)
            {
                if (list[i] == check) return true;
            }
            return false;
        }

      static void Main(string[] args)
        {
            int[] numArrayOn = { 1, 2, 7, 10, 22, 31, 30 };
            bool resultOn = false;
            resultOn = bigO_n_itemInList(7, numArrayOn);
            Console.WriteLine("O(n) result : " + resultOn);
            Console.ReadKey();
        }
        
## O(n^2) - Quadratic   
O(n^2) = ประสิทธิภาพช้า เพราะมีการวน Loop 2 ชั้น

      static String bigO_n2(int[] list)
        {           
            String result = "";
            for (var i = 0; i < list.Length; i++)
            {// O(n)
                for (int j = 0; j < list.Length; j++)
                {// O(n)
                    result= list[i].ToString();
                }
            }
            return result;
        }

      static void Main(string[] args)
        {
            int[] numArrayOn2 = { 1, 2, 7, 10, 22, 31, 30 };
            String resultOn2 =bigO_n2(numArrayOn2);
            Console.WriteLine("O(n²) result : " + resultOn2);
            Console.ReadKey();
        }
        
## O(2^n) - Exponential   
O(2^n) = เลวร้าย การเพิ่มขนาดของ input แค่นิดเดียว ก็ทำให้ระยะเวลาในการประมวลผลเพิ่มขึ้นแบบมหาศาล

      static int fib(int number)
        {
            if (number <= 1) return number;
            else return fib(number - 2) + fib(number - 1);
        }
        
      static void Main(string[] args)
        {
            int result2n=fib(5);
            Console.WriteLine("O(2^n) result : " + result2n);
            Console.ReadKey();
        }
        
## O(log(n)) - Logarithmic   
O(log n) = ตัดจำนวนข้อมูลที่ไม่มีโอกาสเกิดขึ้นออกไปทีละครึ่ง

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
        
      static void Main(string[] args)
        {
            int resultLogN1 = twoDivides(9);
            Console.WriteLine("O(log n) result 1 : " + resultLogN1);
            Console.ReadKey();
        }
        
## O(nlog(n)) - Log Linear  
O(nlog(n)) = เป็นการวนลูปสองรอบ ลูปชั้นนอกวนแบบปกติ (n รอบ) แต่ลูปชั้นในวนแบบตัดข้อมูลที่ไม่เกี่ยวข้องออกไปทีละครึ่งด้วย (log n)

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

      static void Main(string[] args)
        {
            int resultNLogN = nlogn(9);
            Console.WriteLine("nlogn result : " + resultNLogN);
            Console.ReadKey();
        }
        
        
## O(n!) - Factorial        
O(n!) = ชนิดสุดท้ายที่ยกมาในวันนี้เรียกได้ว่าเลวร้ายที่สุดสำหรับ BigO

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
        
        static void Main(string[] args)
        {
            int resultNFact = factorialCheck(6);
            Console.WriteLine("O(n!) result : " + resultNFact);
            Console.ReadKey();
        }


แหล่งอ้างอิง 
: https://itopstory.com/what-why-and-type-big-o-notation-90a1a1d43596#:~:text=Big%20O%20Notation%20%E0%B8%84%E0%B8%B7%E0%B8%AD%20%E0%B8%A3%E0%B8%B0%E0%B8%A2%E0%B8%B0,%E0%B8%A5%E0%B8%81%E0%B8%AD%E0%B8%A3%E0%B8%B4%E0%B8%97%E0%B8%B6%E0%B8%A1%20(Algorithm%20Complexity)

: https://www.borntodev.com/2020/03/21/big-o-%E0%B8%84%E0%B8%B7%E0%B8%AD%E0%B8%AD%E0%B8%B0%E0%B9%84%E0%B8%A3/

: https://blog.rayriffy.com/big-o-notation

: https://github.com/pavankat/big-o-in-plain-english/blob/master/README.md
