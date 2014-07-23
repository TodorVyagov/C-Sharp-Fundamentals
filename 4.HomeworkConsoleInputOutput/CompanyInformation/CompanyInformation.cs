using System;

namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main()
        {
            //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.


            Console.Write("Enter the following information:\nCompany name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company Address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Company phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Manager's First name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager's Family name: ");
            string managerFamilyName = Console.ReadLine();
            Console.Write("Manager's age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager's Phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Information about {0} company:\nAddress: {1}\nPhone number: {2}\nFax: {3}\nWeb site: {4}\nThe manager is: {5} {6}\nHe is {7} years old.\nManager Phone number: {8}.", companyName, companyAddress, companyPhone, companyFax, companyWebSite, managerFirstName, managerFamilyName, managerAge, managerPhone);
        }
    }
}
