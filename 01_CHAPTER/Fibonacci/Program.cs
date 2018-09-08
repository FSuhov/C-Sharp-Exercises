using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number");
            int index = int.Parse(Console.ReadLine());
            long fiboNumber = Fibo.GetFiboNumber(index);
            Console.WriteLine("Iterative: " + fiboNumber);
            fiboNumber = Fibo.GetFiboNumberRecursive(index+1);
            Console.WriteLine("Recursive: "+ fiboNumber);
        }
    }    

    public class Fibo 
    {
        public static long GetFiboNumber(int n)
        {
            long a = 0;
            long b = 1;
            for(int i = 0; i < n; i++)
            {
                long temp = b;
                b = a + b;
                a = temp;
            }
            return b;
        }

        public static long GetFiboNumberRecursive(int n)
        {            
            if (n == 0 || n == 1) return n;
            return (GetFiboNumberRecursive(n - 1) + GetFiboNumberRecursive(n - 2));
        }
    }
}
