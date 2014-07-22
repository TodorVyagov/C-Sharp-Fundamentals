using System;

namespace BankAccountInfo
{
    class BankAccountInfo
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Ivanov";
            string familyName = "Ivanov";
            object wholeName = firstName + " " + middleName + " " + familyName;
            decimal balance = 23650.35M;
            string bankName = "Raiffeisen Bank";
            string iban = "BG76RZBB96611020345678";
            string bic = "RZBBBGSF";
            ulong creditVisa = 4585702380975652u;
            ulong creditAmericanExpress = 341084617228301u;
            ulong creditMasterCard = 5412575850540909u;
            
            Console.WriteLine("{0} has bank account in {2} with balance: {1}$.\nIBAN: {3}\nBIC: {4}\nCredit Cards:\nVisa: {5}\nAmerican Express: {6}\nMaster Card: {7}.", wholeName, balance, bankName, iban, bic, creditVisa, creditAmericanExpress, creditMasterCard);
        }
    }
}
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
