using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long quadronacci0 = long.Parse(Console.ReadLine());
        long quadronacci1 = long.Parse(Console.ReadLine());
        long quadronacci2 = long.Parse(Console.ReadLine());
        long quadronacci3 = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long[,] rectangle = new long[rows, cols];
        rectangle[0, 0] = quadronacci0;
        rectangle[0, 1] = quadronacci1;
        rectangle[0, 2] = quadronacci2;
        rectangle[0, 3] = quadronacci3;


        long currentMember = quadronacci0 + quadronacci1 + quadronacci2 + quadronacci3;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (!(row == 0 && (col == 0 || col ==1 || col ==2 || col == 3)))
                {
                    rectangle[row, col] = currentMember;
                    quadronacci0 = quadronacci1;
                    quadronacci1 = quadronacci2;
                    quadronacci2 = quadronacci3;
                    quadronacci3 = currentMember;
                    currentMember = quadronacci0 + quadronacci1 + quadronacci2 + quadronacci3;
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(rectangle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
