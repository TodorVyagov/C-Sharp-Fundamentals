using System;

namespace RecordOfEmployee
{
    class RecordOfEmployee
    {
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            char gender;
            int idNumber;
            int uniqueNumber;
            Console.Write("Enter first name of the employee: ");
            firstName = Console.ReadLine();
            Console.Write("Enter family name of employee: ");
            familyName = Console.ReadLine();
            Console.Write("Enter the age of employee: ");
            age = byte.Parse(Console.ReadLine());
            Console.Write("Gender of employee: \"F\" for Female and \"M\" for Male: ");
            gender = char.Parse(Console.ReadLine());
            Console.Write("Enter ID number of employee: ");
            idNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter unique employee number(27560000 to 27569999): ");
            uniqueNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The following information was saved:\nEmployee {0} {1} is {2} years old.\nGender: {3}\nID number: {4}\nUnique emplyee number: {5}", firstName, familyName, age, gender, idNumber, uniqueNumber);
        }
    }
}
//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
