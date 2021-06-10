using System;
using System.Collections.Generic;
namespace Exercise4
{
    class Spiral
    {
        public void solution(int[][] A)
        {
            int rows = A.Length, cols = A[0].Length;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Solution to Spiral Matrix: ");
            string result = "";
            int rMin = 0, cMin = 0, currentRow = 0, currentCol = 0;

            while (rMin <= rows-1 && cMin <= cols-1)
            {
                currentCol = cMin;
                while (currentCol <= cols - 1)
                    result += $"{A[rMin][currentCol++]} ";

                currentRow = rMin + 1;
                while (currentRow <= rows - 1)
                    result += $"{A[currentRow++][cols - 1]} ";

                if (rMin != rows - 1 && cMin != cols - 1)
                {
                    currentCol = cols - 1 - 1;
                    while (currentCol >= cMin)
                        result += $"{A[rows - 1][currentCol--]} ";

                    currentRow = rows - 1 - 1;
                    while (currentRow > rMin)
                        result += $"{A[currentRow--][cMin]} ";
                }
                rMin++;cMin++; rows--;cols--;
            }
            Console.WriteLine(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix dimension separated by space (row x column): ");
            var input = Console.ReadLine().Split(' ');
            int rows = Convert.ToInt32(input[0]);
            int cols = Convert.ToInt32(input[1]);

            int[][] matrix = new int[rows][];
            for(int i=0; i<rows; i++)
            {
                Console.WriteLine("Enter each row of matrix (elements separated by space): ");
                var rowInput = Console.ReadLine().Split(' ');
                int[] eachRows = new int[cols];
                for(int j=0; j<cols; j++)
                {
                    eachRows[j] = Convert.ToInt32(rowInput[j]); 
                }
                matrix[i] = eachRows;
            }

            Spiral spiral = new Spiral();
            spiral.solution(matrix);
        }
    }
}
