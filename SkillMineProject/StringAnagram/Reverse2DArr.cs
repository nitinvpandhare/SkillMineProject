using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringAnagram
{
    class Reverse2DArr
    {
        static int row = 3;
        static int col = 3;
        private static int[,] swap(int[,] arr, int start,
                                    int i, int end, int j)
        {

            int temp = arr[start, i];
            arr[start, i] = arr[end, j];
            arr[end, j] = temp;
            return arr;
        }


        static void printMatrix(int[,] arr)
        {

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void reverseColumnArray(int[,] arr)
        {

            printMatrix(arr);
            Console.WriteLine();
            for (int i = 0; i < col; i++)
            {
                int start = 0;
                int end = row - 1;

                while (start < end)
                {

                    arr = swap(arr, start, i, end, i);

                    start++;
                    end--;
                }
            }

            printMatrix(arr);
        }

        public static void Main()
        {
            int[,] arr = { { 3, 2, 1 }, { 4, 5, 6 }, { 9, 8, 7 } };
            Console.WriteLine("Reverse 2D ARRAY");
            reverseColumnArray(arr);
        }
    }
}
