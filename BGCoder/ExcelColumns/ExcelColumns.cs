using System;

namespace ExcelColumns
{
    class ExcelColumns
    {
        static void Main()
        {
            int columnIdentifierLenght = int.Parse(Console.ReadLine());
            char[] columnIdentifier = new char[columnIdentifierLenght];
            long columnIndex = 0;
            for (int i = columnIdentifierLenght - 1; i >= 0; i--)
            {
                columnIdentifier[i] = char.Parse(Console.ReadLine());
            }
            //Now we have to transform our Letter into a number.
            int[] columniIdentifierNumber = new int[columnIdentifierLenght];
            for (int i = 0; i < columnIdentifierLenght; i++)
            {
                columniIdentifierNumber[i] = columnIdentifier[i] - 'A' + 1;
                columnIndex += columniIdentifierNumber[i] * (long)Math.Pow(26, i);
            }
            Console.WriteLine(columnIndex);
        }
    }
}
