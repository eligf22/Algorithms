using System;

namespace AlgorithmsPracticeLibrary
{
    public class Fibonacci
    {
        public static int Recursive_Fib(int n)
        {
            //0,1,1,2,3,5,8,13,21
            if(n <= 1)
            {
                return n;
            }
            
            return Recursive_Fib(n-1) + Recursive_Fib(n-2);
        }
    }
}