using System;

class BitTowerOfDoom
{
    static void Main()
    {
        int[,] tower = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int currentChariot = int.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                tower[i, 7 - j] = (currentChariot >> j) & 1;
            }
        }

        int knightsEnteredTheTower = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (tower[i, j] == 1)
                {
                    knightsEnteredTheTower++;
                }
            }
        }
        Console.WriteLine(knightsEnteredTheTower);
        
        //Fights
        while (true)
        {
            string command = Console.ReadLine();
            
            if (command == "end")
            {
                break;
            }
            
            int selectedRow = int.Parse(Console.ReadLine());
            int selectedCol = int.Parse(Console.ReadLine());
            tower[selectedRow, selectedCol] = 0;

            command = Console.ReadLine();
            int destinationRow = int.Parse(Console.ReadLine());
            int destinationCol = int.Parse(Console.ReadLine());

            if (command == "kill")
            {
                if (tower[destinationRow, destinationCol] == 1)
                {
                    //do nothing - he will just replace the knight

                }
                else //the cell is empty, if only one of the neighbor cells is full everybody dies...
                {
                    if (destinationCol - 1 >= 0 && destinationCol + 1 <= 7) 
                    {
                        if ((tower[destinationRow, destinationCol - 1] == 0) ^ (tower[destinationRow, destinationCol + 1] == 0)) 
                        {
                            tower[destinationRow, destinationCol - 1] = 0;
                            tower[destinationRow, destinationCol + 1] = 0;
                        } 
                    }
                    else if (destinationCol + 1 <= 7)
                    {
                        if (tower[destinationRow, destinationCol - 1] == 1)
                        {
                            tower[destinationRow, destinationCol - 1] = 0;
                        }
                    }
                    else if (destinationCol - 1 >= 0)
                    {
                        if (tower[destinationRow, destinationCol + 1] == 1)
                        {
                            tower[destinationRow, destinationCol + 1] = 0;
                        }
                    }
                    if ((tower[destinationRow, destinationCol - 1] == 0) &&
                        (tower[destinationRow, destinationCol + 1] == 0) &&
                        (tower[destinationRow, destinationCol] == 0))
                    {
                        tower[destinationRow, destinationCol] = 1;
                    }
                }
            }
            else if (command == "move")
            {
                if (destinationCol - 1 >= 0 && destinationCol + 1 <= 7)
                {
                    if ((tower[destinationRow, destinationCol - 1] == 1) ||
                        (tower[destinationRow, destinationCol + 1] == 1) || 
                        (tower[destinationRow, destinationCol] == 1))
                    {
                        //do nothing - the knight who wants to move is dead
                    }
                    else
                    {
                        tower[destinationRow, destinationCol] = 1; 
                    }
                }
                else if (destinationCol + 1 <= 7)
                {
                    if ((tower[destinationRow, destinationCol - 1] == 1) ||
                        (tower[destinationRow, destinationCol] == 1))
                    {
                        //do nothing - the knight who wants to move is dead
                    }
                    else
                    {
                        tower[destinationRow, destinationCol] = 1;
                    }
                }
                else if (destinationCol - 1 >= 0)
                {
                    if ((tower[destinationRow, destinationCol + 1] == 1) || 
                        (tower[destinationRow, destinationCol] == 1))
                    {
                        //do nothing - the knight who wants to move is dead
                    }
                    else
                    {
                        tower[destinationRow, destinationCol] = 1;
                    }
                }

            }
        } // End of wlile loop
        
        int knightsLeftInTheTower = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (tower[i, j] == 1)
                {
                    knightsLeftInTheTower++;
                }
            }
        }
        Console.WriteLine(knightsLeftInTheTower);

        for (int i = 7; i >= 0; i--)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(tower[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}
