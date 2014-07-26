using System;

class FighterAttack
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());
        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        if (pX1 > pX2) //pX1 - left side of plant, pX2 - right side of plant
        {
            pX1 ^= pX2;
            pX2 ^= pX1;
            pX1 ^= pX2;
        }

        if (pY1 < pY2) //pY1 - top of plant, pY2 bottom of plant 
        {
            pY1 ^= pY2;
            pY2 ^= pY1;
            pY1 ^= pY2;
        }

        int hitX = fX + D;
        int hitY = fY;
        int damage = 0;

        if (hitX >= pX1 && hitX <= pX2 && hitY <= pY1 && hitY >= pY2)
        {
            damage += 100;
        }

        if (hitX >= pX1 && hitX <= pX2 && (hitY + 1) <= pY1 && (hitY + 1) >= pY2)//above hit point
        {
            damage += 50;
        }

        if (hitX >= pX1 && hitX <= pX2 && (hitY - 1) <= pY1 && (hitY - 1) >= pY2)//below hit point
        {
            damage += 50;
        }

        if ((hitX + 1) >= pX1 && (hitX + 1) <= pX2 && hitY <= pY1 && hitY >= pY2)//point right of hit point
        {
            damage += 75;
        }

        Console.WriteLine(damage + "%");
    }
}
