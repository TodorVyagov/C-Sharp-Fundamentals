using System;

class PrintAgeIn10years
{
    static void Main()
    {
        //Write a program to read your age from the console and print how old you will be after 10 years.

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("In 10 years you will be " + (age + 10));
    }
}
