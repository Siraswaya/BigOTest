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

      static void Main(string[] args)
        {
            String resultO1 = bigO_1_evenOrOdd(5);
            Console.WriteLine("O(1) result : " + resultO1);
            Console.ReadKey();
        }

## O(n) - Linear      

      static void Main(string[] args)
        {
            int[] numArrayOn = { 1, 2, 7, 10, 22, 31, 30 };
            bool resultOn = false;
            resultOn = bigO_n_itemInList(7, numArrayOn);
            Console.WriteLine("O(n) result : " + resultOn);
            Console.ReadKey();
        }
        
## O(n^2) - Quadratic     

      static void Main(string[] args)
        {
            int[] numArrayOn2 = { 1, 2, 7, 10, 22, 31, 30 };
            String resultOn2 =bigO_n2(numArrayOn2);
            Console.WriteLine("O(n²) result : " + resultOn2);
            Console.ReadKey();
        }
        
## O(2^n) - Exponential   

      static void Main(string[] args)
        {
            int result2n=fib(5);
            Console.WriteLine("O(2^n) result : " + result2n);
            Console.ReadKey();
        }
        
## O(log(n)) - Logarithmic   

      static void Main(string[] args)
        {
            int resultLogN1 = twoDivides(9);
            Console.WriteLine("O(log n) result 1 : " + resultLogN1);
            Console.ReadKey();
        }
        
## O(nlog(n)) - Log Linear  

      static void Main(string[] args)
        {
            int resultNLogN = nlogn(9);
            Console.WriteLine("nlogn result : " + resultNLogN);
            Console.ReadKey();
        }
        
        
## O(n!) - Factorial        

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

