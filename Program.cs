using System;

namespace FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to get the fib result - ");
            
            int [] memo= {0,1,1,0,0,0,0,0,0,0,0};
            
            Console.WriteLine(string.Join(',',memo));
            int number=10;
            var result = fib_recursive(number,memo);
            var result1 = fib_iterative(number);
            Console.WriteLine(string.Join(',',memo));
            Console.WriteLine("result is- " + result1);
        }
        static int fib_recursive(int n, int [] memo)
        {
            var result=1;
            if(memo[n]!=0)
            {
                return memo[n];
            }
            if(n==1 || n==2)
            {
               return 1;
            }
            else
            {
                result=fib_recursive(n-1,memo)+fib_recursive(n-2,memo);
                memo[n]=result;
                return result;
            }
        }
        static int fib_iterative(int n)
        {
            if(n==1 || n==2)
            {
                return 1;
                
            }
            int [] bottom_up= {0,1,1,0,0,0,0,0,0,0,0};
            for(int i =3;i<n+1;i++)
            {
                bottom_up[i]=bottom_up[i-1]+bottom_up[i-2];
            }
            Console.WriteLine(string.Join(',',bottom_up));
            return bottom_up[n];
        }
    }
}