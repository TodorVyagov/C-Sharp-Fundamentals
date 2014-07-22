using System;

namespace ExchangeUintBits
{
    class ExchangeUintBits
    {
        static void Main()
        {
            Console.Write("Enter integer number (between {0} and {1}): ",uint.MinValue, uint.MaxValue);
            uint number = uint.Parse(Console.ReadLine());
            
            Console.Write("{0,-40}", "Binary value of number =");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            //Starting with exchange of 3-rd and 24-th bits
            uint mask3 = 1 << 3;
            //You can Uncomment these lines below. It was easier to me to build the program with them.
            //Console.Write("{0,-40}", "Binary value of mask3 =");
            //Console.WriteLine(Convert.ToString(mask3, 2).PadLeft(32, '0'));
            uint valueOf3rdBit = number & mask3;
            //Console.Write("{0,-40}", "Binary value of valueOf3rdBit =");
            //Console.WriteLine(Convert.ToString(valueOf3rdBit, 2).PadLeft(32, '0'));
            valueOf3rdBit = valueOf3rdBit >> 3; //The value of 3rd bit is taken and saved

            uint mask24 = 1 << 24;
            //Console.Write("{0,-40}", "Binary value of mask24 =");
            //Console.WriteLine(Convert.ToString(mask24, 2).PadLeft(32, '0'));
            uint valueOf24thBit = number & mask24;
            //Console.Write("{0,-40}", "Binary value of valueOf24thBit =");
            //Console.WriteLine(Convert.ToString(valueOf24thBit, 2).PadLeft(32, '0'));
            valueOf24thBit = valueOf24thBit >> 24; //The value of 24-th bit is taken(0 or 1) and saved and now they can be exchanged
            uint exchangedNumber = new uint();
            if (valueOf3rdBit == 0)
            {
                valueOf3rdBit = 1; //Otherwise we will invert 000000 to 111111, but we need to have one 0
                valueOf3rdBit = ~(valueOf3rdBit << 24);
                exchangedNumber = valueOf3rdBit & number; //Assigning the value of 3rd bit as 24th
            }
            else
            {
                valueOf3rdBit = valueOf3rdBit << 24;
                exchangedNumber = valueOf3rdBit | number; //Assigning the value of 3rd bit as 24th
            }
            if (valueOf24thBit == 0)
            {
                valueOf24thBit = 1;
                valueOf24thBit = ~(valueOf24thBit << 3);
                exchangedNumber = valueOf24thBit & exchangedNumber; //Assigning the value of 24th bit as 3rd
            }
            else
            {
                valueOf24thBit = valueOf24thBit << 3;
                exchangedNumber = valueOf24thBit | exchangedNumber; //Assigning the value of 24th bit as 3rd
            }
            //Console.Write("{0,-40}", "Value of Number After 3 and 24 swap =");
            //Console.WriteLine(Convert.ToString(exchangedNumber, 2).PadLeft(32, '0'));

            //Exchange of 4-th and 25-th bits
            uint mask4 = 1 << 4;
            uint valueOf4thBit = number & mask4;
            valueOf4thBit = valueOf4thBit >> 4; //The value of 4th bit is saved
            uint mask25 = 1 << 25;
            uint valueOf25thBit = number & mask25;
            valueOf25thBit = valueOf25thBit >> 25; //The value of 25th bit is saved, it is time to be exchanged
            if (valueOf4thBit == 0)
            {
                valueOf4thBit = 1;
                valueOf4thBit = ~(valueOf4thBit << 25);
                exchangedNumber = valueOf4thBit & exchangedNumber; //Assigning the value of 4th bit as 25th
            }
            else
            {
                valueOf4thBit = valueOf4thBit << 25;
                exchangedNumber = valueOf4thBit | exchangedNumber; //Assigning the value of 4th bit as 25th
            }
            if (valueOf25thBit == 0)
            {
                valueOf25thBit = 1;
                valueOf25thBit = ~(valueOf25thBit << 4);
                exchangedNumber = valueOf25thBit & exchangedNumber; //Assigning the value of 25th bit as 4th
            }
            else
            {
                valueOf25thBit = valueOf25thBit << 4;
                exchangedNumber = valueOf25thBit | exchangedNumber; //Assigning the value of 25th bit as 4th
            }
            //Console.Write("{0,-40}", "Value of Number After 4 and 25 swap =");
            //Console.WriteLine(Convert.ToString(exchangedNumber, 2).PadLeft(32, '0'));

            //Exchange values of 5th and 26th bits
            uint mask5 = 1 << 5;
            uint valueOf5thBit = mask5 & number;
            valueOf5thBit = valueOf5thBit >> 5; //Saved value of 5th bit( 0 or 1)
            uint mask26 = 1 << 26;
            uint valueOf26thBit = mask26 & number;
            valueOf26thBit = valueOf26thBit >> 26; //Saved value of 26th bit, time for exchange
            if (valueOf5thBit == 0)
            {
                valueOf5thBit = 1;
                valueOf5thBit = ~(valueOf5thBit << 26);
                exchangedNumber = valueOf5thBit & exchangedNumber; //Assigning the value of 5th bit as 26th 
            }
            else
            {
                valueOf5thBit = valueOf5thBit << 26;
                exchangedNumber = valueOf5thBit | exchangedNumber; //Assigning the value of 5th bit as 26th 
            }
            if (valueOf26thBit == 0)
            {
                valueOf26thBit = 1;
                valueOf26thBit = ~(valueOf26thBit << 5);
                exchangedNumber = valueOf26thBit & exchangedNumber; //Assigning the value of 26th bit as 5th 
            }
            else
            {
                valueOf26thBit = valueOf26thBit << 5;
                exchangedNumber = valueOf26thBit | exchangedNumber; //Assigning the value of 26th bit as 5th 
            }
            Console.Write("{0,-40}", "Value of Number After all exchanges =");
            Console.WriteLine(Convert.ToString(exchangedNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("Now the value of exchanged number is: " + exchangedNumber);
        }
    }
}
