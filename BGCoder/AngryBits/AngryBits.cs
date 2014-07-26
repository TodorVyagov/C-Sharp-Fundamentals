using System;

class AngryBits
{
    static void Main()
    {
        int[,] grid = new int[8, 16];

        //Filling the grid
        for (int i = 0; i < 8; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            for (int j = 0; j < 16; j++)
            {
                grid[i, j] = (currentNum >> j) & 1;
            }
        }

        //Solution
        int totalScore = 0;
        bool isWonGame = true;
        int lastColWhereWeFoundBird = 8;
        bool isEndOfFieldReached = false;

        while (true)
        {
            if (isEndOfFieldReached)
            {
                break;
            }
            int startFlightPositionRow = 0;
            int startFlightPositionCol = 8;
            bool isBirdFound = false;
            int lenghtOfFlight = 0;
            int pigsDestroyed = 0;
            bool isPigReached = false;
            int pigHitRow = 0;
            int pigHitCol = 0;

            for (int col = lastColWhereWeFoundBird; col < 16; col++) //Searching for bird
            {
                if (isBirdFound)
	            {
		            break;
	            }
                for (int row = 0; row < 8; row++)
                {
                    if (grid[row, col] == 1)
                    {
                        isBirdFound = true;
                        startFlightPositionRow = row;
                        startFlightPositionCol = col;
                        lastColWhereWeFoundBird++;
                        break;
                    }
                    if (row == 7 && col == 15)
                    {
                        isEndOfFieldReached = true;
                    }
                }
            } //end of searching bird

            if (isBirdFound) //Flight of bird
            {
                int currentFlightLenght = 0;
                bool isFlyingUpwards = true;

                if (startFlightPositionRow == 0)
                {
                    isFlyingUpwards = false;
                }

                if (isFlyingUpwards) //So its gonna fly upwards
                {
                    int currentPositionRow = startFlightPositionRow - 1;
                    int currentPositionCol = startFlightPositionCol - 1;
                    while (true)
                    {
                        if (grid[currentPositionRow, currentPositionCol] == 0)
                        {
                            currentFlightLenght++;
                        }
                        else //we found a pig
                        {
                            isPigReached = true;
                            pigHitRow = currentPositionRow;
                            pigHitCol = currentPositionCol;
                            currentFlightLenght++;
                            lenghtOfFlight += currentFlightLenght;
                            break;
                        }
                        currentPositionRow--;
                        currentPositionCol--;
                        if (currentPositionRow < 0)
                        {
                            startFlightPositionRow = currentPositionRow + 1;
                            startFlightPositionCol = currentPositionCol + 1;
                            break;
                        }
                    }
                }// end of flying upwards

                if (isPigReached == false) // starts flying downwards
                {
                    int currentPositionRow = startFlightPositionRow + 1;
                    int currentPositionCol = startFlightPositionCol - 1;
                    while (true)
                    {
                        if (grid[currentPositionRow, currentPositionCol] == 0)
                        {
                            currentFlightLenght++;
                        }
                        else//we found a pig
                        {
                            isPigReached = true;
                            pigHitRow = currentPositionRow;
                            pigHitCol = currentPositionCol;
                            currentFlightLenght++;
                            lenghtOfFlight += currentFlightLenght;
                            break;
                        }
                        currentPositionRow++;
                        currentPositionCol--;

                        if (currentPositionRow > 7 || currentPositionCol < 0)
                        {
                            isEndOfFieldReached = true;
                            break;
                        }
                    }
                } // end of flying downwards
            } // end of bird flight

            if (isPigReached) //Count score 
            {
                for (int row = pigHitRow - 1; row <= pigHitRow + 1; row++) //Searching for neightbor pigs
                {
                    for (int col = pigHitCol - 1; col <= pigHitCol + 1; col++)
                    {
                        if ((row >= 0 && row <= 7) && (col >= 0 && col <= 7))
                        {
                            if (grid[row, col] == 1)
                            {
                                pigsDestroyed++;
                            }
                            grid[row, col] = 0;
                        }
                    }
                }

                totalScore += pigsDestroyed * lenghtOfFlight;
            } // end of count score
        } // end of wlile loop

        for (int row = 0; row < 8; row++) //Check if there are any pigs left
        {
            for (int col = 0; col < 8; col++)
            {
                if (grid[row, col] == 1)
                {
                    isWonGame = false;
                }
            }

        }

        if (isWonGame)
        {
            Console.WriteLine(totalScore + " Yes");
        }
        else
        {
            Console.WriteLine(totalScore + " No");
        }

        //Print grid
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 16; j++)
        //    {
        //        Console.Write(grid[i, 16 - 1 - j] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}
