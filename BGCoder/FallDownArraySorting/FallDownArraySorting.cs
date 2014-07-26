using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDownArraySorting
{
    class FallDownArraySorting
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string numToBinaryString = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = int.Parse(numToBinaryString[j].ToString());
                }
            }

            for (int col = 0; col < 8; col++)
            {
                int[] temp = new int[8];
                int count = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        count++;
                        temp[row] = 1;
                    }
                }
                Array.Sort(temp);

                for (int i = 0; i < 8; i++)
                {
                    matrix[7 - i, col] = temp[7 - i];
                }
            }

            //Printing the array
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();

                
            //}
            //Output

            for (int i = 0; i < 8; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < 8; j++)
                {
                    sb.Append(matrix[i, j]);
                }
                int num = Convert.ToInt32(sb.ToString(), 2);
                Console.WriteLine(num);
            }
        }
    }
}
