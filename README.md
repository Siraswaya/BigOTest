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



## O(n) - Linear        
## O(n^2) - Quadratic        
## O(2^n) - Exponential   
## O(log(n)) - Logarithmic   
## O(nlog(n)) - Log Linear    
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
        
        }

