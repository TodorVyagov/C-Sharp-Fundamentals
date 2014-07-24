using System;

class Subsets
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of integers: ");
        int numberOfIntegers = int.Parse(Console.ReadLine());
        int[] setOfIntegers = new int[numberOfIntegers];
        for (int number = 0; number < numberOfIntegers; number++)
        {
            Console.Write("Enter integer number {0} ", number + 1);
            setOfIntegers[number] = int.Parse(Console.ReadLine());
        }
        //iterate all subsets
        for (int subsets = 1; subsets <= (1 << numberOfIntegers) - 1; subsets++)
        {
            Console.WriteLine("subsets = " + Convert.ToString(subsets, 2).PadLeft(8, '0'));
            int sum = 0;
            for (int bit = 0; bit < numberOfIntegers; bit++)
            {
                Console.WriteLine("bit     = " + Convert.ToString(bit, 2).PadLeft(8, '0'));
                if (0 != (subsets & (1 << bit)))
                {
                    Console.WriteLine("sum = " + sum);
                    sum += setOfIntegers[bit];
                    Console.WriteLine("setOfIntegers" + setOfIntegers[bit]);
                    Console.WriteLine("sum = " + sum);
                }
            }
            if (sum == 0)
            {
                //break - we found a subset whose
                Console.WriteLine("Found a subset whose sum is 0.");
                for (int bit = 0; bit < numberOfIntegers; bit++)
                {
                    if (0 != (subsets & (1 << bit)))
                    {
                        Console.WriteLine("Element {0} with value {1}", bit + 1, setOfIntegers[bit]);
                    }
                }
            }
        }
    }
}