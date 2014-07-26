using System;

class TribonacciTriangle
{
    static void Main()
    {
        long numberOne = long.Parse(Console.ReadLine());
        long numberTwo = long.Parse(Console.ReadLine());
        long numberThree = long.Parse(Console.ReadLine());
        long currentNumber;
        int L = int.Parse(Console.ReadLine());
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo +  " " + numberThree);
        currentNumber = numberOne + numberTwo + numberThree;

        for (int row = 3; row <= L; row++)
        {
            for (int col = 0; col < row - 1; col++)
            {
                Console.Write(currentNumber + " ");
                numberOne = numberTwo;
                numberTwo = numberThree;
                numberThree = currentNumber;
                currentNumber = numberOne + numberTwo + numberThree;
            }
            Console.WriteLine(currentNumber);
            numberOne = numberTwo;
            numberTwo = numberThree;
            numberThree = currentNumber;
            currentNumber = numberOne + numberTwo + numberThree;
        }
    }
}
