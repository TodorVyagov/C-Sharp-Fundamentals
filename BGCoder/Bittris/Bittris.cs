using System;

namespace Bittris
{
    class Bittris
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int totalRounds = N / 4;//N >> 2
            char[,] playGround = new char[4, 8];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    playGround[i, j] = '0';
                }
            }
            int result = 0;
            bool isGameOver = false;
            for (int currentRound = 0; currentRound < totalRounds; currentRound++)
            {
                if (isGameOver)
                {
                    break;
                }
                uint number = uint.Parse(Console.ReadLine());
                char[] numberToCharArray = Convert.ToString(number, 2).PadLeft(32, '0').ToCharArray();
                //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                byte lastEightBitsOfNumber = (byte)number;
                //Console.WriteLine(Convert.ToString(lastEightBitsOfNumber, 2).PadLeft(32, '0'));
                char[] tetrisFigure = Convert.ToString(lastEightBitsOfNumber, 2).PadLeft(8, '0').ToCharArray();
                //Console.WriteLine(tetrisFigure);
                bool isLanded = false;
                bool wasCounted = false;
                for (int col = 0; col < 8; col++)
                {
                    playGround[0, col] = tetrisFigure[col];
                }
                for (int i = 0; i < 3; i++)
                {
                    string currentAction = Console.ReadLine();
                    if (isGameOver)
                    {
                        continue;
                    }
                    if (!isLanded)
                    {
                        if (currentAction == "D")
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (playGround[i, j] == '1' && playGround[i + 1, j] == '1')
                                {
                                    isLanded = true;
                                    if (i == 0)
                                    {
                                        isGameOver = true;
                                    }
                                    break;
                                }
                            }
                            if (!isLanded)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (playGround[i, j] == '1')
                                    {
                                        playGround[i, j] = '0';
                                        playGround[i + 1, j] = '1';
                                    }
                                    if (i + 1 == 3 && j == 7)
                                    {
                                        isLanded = true;
                                        break;
                                    }
                                }
                            }

                        }
                        else if (currentAction == "L")
                        {
                            if (playGround[i, 0] == '0')
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    playGround[i, j] = playGround[i, j + 1];
                                    if (j == 6)
                                    {
                                        playGround[i, j + 1] = '0';
                                        break;
                                    }
                                }
                            }
                            for (int j = 0; j < 8; j++)
                            {
                                if (playGround[i, j] == '1' && playGround[i + 1, j] == '1')
                                {
                                    isLanded = true;
                                    break;
                                }
                            }
                            if (!isLanded)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (playGround[i, j] == '1')
                                    {
                                        playGround[i, j] = '0';
                                        playGround[i + 1, j] = '1';
                                        if (i + 1 == 3 && j == 7)
                                        {
                                            isLanded = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else//currentAction == "R"
                        {
                            if (playGround[i, 7] == '0')
                            {
                                for (int j = 7; j >= 0; j--)
                                {
                                    playGround[i, j] = playGround[i, j - 1];
                                    if (j == 1)
                                    {
                                        playGround[i, j - 1] = '0';
                                        break;
                                    }
                                }
                            }
                            for (int j = 0; j < 8; j++)
                            {
                                if (playGround[i, j] == '1' && playGround[i + 1, j] == '1')
                                {
                                    isLanded = true;
                                    break;
                                }
                            }
                            if (!isLanded)
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (playGround[i, j] == '1')
                                    {
                                        playGround[i, j] = '0';
                                        playGround[i + 1, j] = '1';
                                        if (i + 1 == 3 && j == 7)
                                        {
                                            isLanded = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (isLanded && !wasCounted) //Counting result and clearing if a whole row is full of '1'
                    {

                        wasCounted = true;
                        //Console.WriteLine("the piece has landed?");
                        int currentResult = 0;
                        bool isWholeRowFullOfOnes = true;
                        for (int j = 0; j < 32; j++)
                        {
                            if (numberToCharArray[j] == '1')
                            {
                                currentResult++;
                            }
                        }
                        for (int j = 0; j < 8; j++)
                        {
                            if (playGround[i, j] == '0')
                            {
                                isWholeRowFullOfOnes = false;
                            }
                        }
                        if (isWholeRowFullOfOnes)
                        {
                            currentResult *= 10;
                            for (int j = 0; j < 8; j++)
                            {
                                playGround[i, j] = '0';
                            }
                        }

                        result += currentResult;
                    }
                    //for (int printRow = 0; printRow < 4; printRow++)
                    //{
                    //    for (int j = 0; j < 8; j++)
                    //    {
                    //        Console.Write(playGround[printRow, j]);
                    //    }
                    //    Console.WriteLine();
                    //}
                    //Console.WriteLine("result = " + result);
                }

            }//end of cicle of number and three Actions

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(playGround[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine(result);


        }
    }
}