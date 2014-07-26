using System;
using System.Collections.Generic;

namespace Neurons
{
    class Neurons
    {
        static void Main()
        {
        http://www.youtube.com/watch?v=OnRRd94NHv4 
            //58:41min
            string inputNumber = Console.ReadLine();
            while (inputNumber != "-1")
            {
                uint intNumber = uint.Parse(inputNumber);
                inputNumber = Convert.ToString(intNumber, 2).PadLeft(32, '0');
                int outputNumber = 0;
                bool isOnBoundary = false;
                bool wasItInNeuron= false;
                bool isInNeuron = false;
                bool isAssignedOne = false;
                int counter = 0;
                //for (int i = 0; i < 32; i++)
                //{
                //    Console.Write(inputNumber[i]);
                //}
                //Console.WriteLine();
                for (int i = 0; i < 32; i++)
                {
                    if (inputNumber[i] == '1')
                    {
                        outputNumber &= ~(1 << (31 - i));//assigns 0
                        if (!isOnBoundary)
                        {
                            counter++;
                            isOnBoundary = true;
                        }
                        if (isInNeuron)
                        {
                            wasItInNeuron = true;
                        }
                    }
                    else //inputNumber[31 - i] == '0';
                    {
                        if (counter % 2 != 0)
                        {
                            outputNumber |= (1 << (31 - i));//assigns 1
                            isInNeuron = true;
                            isOnBoundary = false;
                        }
                    }
                }
                if (!wasItInNeuron)
                {
                    outputNumber = 0;
                }


                //Console.WriteLine(Convert.ToString(outputNumber, 2).PadLeft(32, '0'));
                Console.WriteLine(outputNumber);









                inputNumber = Console.ReadLine();

            }




        }
    }
}
