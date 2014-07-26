using System;
using System.Linq;
using System.Text;

namespace FallDown
{
    class FallDown
    {
        static void Main()
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
                int count = 0;
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        count++;
                        matrix[row, col] = 0;
                    }
                    
                }
                for (int i = 0; i < count; i++)
                {
                    matrix[7 - i, col] = 1;
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
