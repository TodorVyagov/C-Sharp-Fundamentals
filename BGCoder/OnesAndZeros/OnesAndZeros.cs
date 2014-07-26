using System;

class OnesAndZeros
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        char[,] numBinary = new char[5, 63];

        for (int i = 0; i < 5; i++) //Filling in the matrix with zeros
        {
            for (int j = 0; j < 63; j++)
            {
                if (i == 0 || i == 4)
                {
                    numBinary[i, j] = '#';
                    if ((j + 1) % 4 == 0)
                    {
                        numBinary[i, j] = '.';
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        numBinary[i, j] = '#';
                    }
                    else
                    {
                        numBinary[i, j] = '.';
                    }
                }
            }
        }//end of filling with zeros

        //Starting to change the bits with value 1
        for (int i = 0; i < 16; i++)
        {
            if (((num >> i) & 1) == 1)
            {
                for (int k = 0; k <= 3; k++)
                {
                    for (int j = i * 4; j < i * 4 + 3; j++)
                    {
                        if (j % 2 == 0)
                        {
                            numBinary[k, j] = '.';
                        }
                        else
                        {
                            numBinary[k, j] = '#';
                        }

                        if (k == 1)
                        {
                            numBinary[k, i * 4 + 2] = '#';
                        }
                    }
                }
            }
        }

        //Printing
        for (int i = 0; i < 5; i++)
        {
            for (int j = 62; j >= 0; j--)
            {
                Console.Write(numBinary[i, j]);
            }
            Console.WriteLine();
        }

    }
}
