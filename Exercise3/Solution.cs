using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            if (A < B)
            {
                return Convert.ToInt32(Math.Floor(Math.Sqrt(B)) - Math.Floor(Math.Sqrt(A))) + 1;
            }
            else
            {
                Console.WriteLine("Invalid inputs, a must be less than b!!!");
                return  0;
            }
        }
    }
}
