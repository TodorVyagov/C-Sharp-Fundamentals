using System;
 
class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rows = n / 2;
        int cols = rows;
        char[,] matrix = new char[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            int counter = 0;
            for (int col = 0; col < cols; col++)
            {
                
                if (col < rows - row - 1)
                {
                    matrix[row, col] = '.';
                }
                else if(counter % 2 == 0)
                {
                    matrix[row, col] = '/';
                    counter++;
                }
                else
                {
                    counter++;
                    matrix[row, col] = ' ';
                }
            }
               
        }
        char[,] matrixRight = new char[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int counter = 0;
            for (int col = 0; col < cols; col++)
            {

                if (col < rows - row - 1)
                {
                    matrixRight[row, col] = '.';
                }
                else if (counter % 2 == 0)
                {
                    matrixRight[row, col] = '\\';
                    counter++;
                }
                else
                {
                    counter++;
                    matrixRight[row, col] = ' ';
                }
            }

        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
            }
            for (int k = cols - 1; k >= 0; k--)
            {
                Console.Write(matrixRight[i, k]);
            }
            Console.WriteLine();
        }
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int k = 0; k < cols; k++)
            {
                Console.Write(matrixRight[i, k]);
            }
            for (int j = cols - 1; j >= 0; j--)
            {
                Console.Write(matrix[i, j]);
            }
            
            Console.WriteLine();
        }

    }
}
