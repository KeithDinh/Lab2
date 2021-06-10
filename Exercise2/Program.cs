using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Each Element (Integer only): ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Solution is: ");
            Console.WriteLine(new Solution().solution(arr)); 
        }
    }
}
