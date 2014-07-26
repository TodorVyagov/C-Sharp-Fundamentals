using System;

namespace Garden
{
    class garden
    {
        static void Main()
        {
            int[] seeds = new int[6];
            int[] area = new int[6];
            for (int i = 0; i < 6; i++)
            {
                seeds[i] = int.Parse(Console.ReadLine());
                if (i < 5)
                {
                    area[i] = int.Parse(Console.ReadLine());
                }
            }
            int seedArea = 250;
            double[] price = {0.5, 0.4, 0.25, 0.6, 0.3, 0.4};

            for (int i = 0; i < 5; i++)
            {
                seedArea -= area[i]; 
            }
            area[5] = seedArea;
            double totalCost = 0;
            for (int i = 0; i < 6; i++)
            {
                totalCost += seeds[i] * price[i];
            }
            Console.WriteLine("Total costs: {0:0.00}", totalCost);
            if (area[5] > 0)
            {
                Console.WriteLine("Beans area: " + area[5]);
            }
            else if (area[5] == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
