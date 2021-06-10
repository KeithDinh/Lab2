using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new Solution().solution(a,b));
        }
    }
}
