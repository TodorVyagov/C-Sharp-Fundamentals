using System;

class Print10MembersOfSequence
{
    static void Main()
    {
        //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
            } //If remainder is 0 so the number is even.
            else
            {
                Console.Write("; -" + i + "; ");
            } //If there is remainder when you divide number by 2 the number is odd.
        }
    }
}
//Prints:
//2; -3; 4; -5; 6; -7; 8; -9; 10; -11;