using System;

class Program
{
    static void Main()
    {
        char letterOne = char.Parse(Console.ReadLine());
        char letterTwo = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        Console.WriteLine(letterOne); //First line output
        
        for (int line = 1, lineCounter = 0; line < lines; line++, lineCounter++)
        {
            Console.Write(letterTwo);

            for (int whiteSpaces = 0; whiteSpaces < lineCounter; whiteSpaces++)
            {
                Console.Write(" ");
            }
            
            letterOne = CalculateLetter(letterOne, letterTwo);
            Console.WriteLine(letterOne);
            letterTwo = CalculateLetter(letterOne, letterTwo);
        }
    }

    static char CalculateLetter(char letterOne, char letterTwo)
    {
        int letterOneAlphabetIndex = letterOne - 'A' + 1;
        int letterTwoAlphabetIndex = letterTwo - 'A' + 1;

        int resultLetterAlphabetIndex = (letterOneAlphabetIndex + letterTwoAlphabetIndex) % 26;

        if (resultLetterAlphabetIndex == 0)
        {
            return 'Z';
        }
        else
        {
            return (char)(resultLetterAlphabetIndex + 'A' - 1);
        }
    }
}

