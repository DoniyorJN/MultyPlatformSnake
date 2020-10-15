using System;
using System.Threading;
namespace Reptile
{
    class Programm
    {

        static void Main(string[] args)
        {
            bool isExit = false;
            bool gameModePrize = false;
            bool gameModeChangeSpeed = false;
            int speed = 150;
            while (true)
            {
                
                Random random = new Random();
                while (true)
                {
                    //********************* Menu **************************
                    Console.BackgroundColor = ConsoleColor.White;
                    string number;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(new string('-', 50));
                    Console.SetCursorPosition(20, 1);
                    Console.WriteLine("Settings");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("1: Game mode");
                    Console.WriteLine("2: Dificulty of game");
                    Console.WriteLine("3: Start");
                    Console.WriteLine("4: Help");
                    Console.WriteLine("5: Exit");
                    Console.Write("Enter number to choose menu:");
                    number = Console.ReadLine();
                    if (int.TryParse(number, out int iNum))
                    {
                        if (iNum == 1)
                        {
                            while (true)
                            {
                                string modeNumber;
                                Console.Clear();
                                Console.WriteLine(new string('-', 50));
                                Console.SetCursorPosition(20, 1);
                                Console.WriteLine("Settings");
                                Console.WriteLine(new string('-', 50));
                                Console.WriteLine("1: Classic");
                                Console.WriteLine("2: With prizes");
                                Console.WriteLine("3: Change Speed");
                                Console.Write("Enter number to choose menu:");
                                modeNumber = Console.ReadLine();
                                if (int.TryParse(modeNumber, out int modeNum))
                                {
                                    if (modeNum == 1)
                                    {
                                        gameModePrize = false;
                                        gameModeChangeSpeed = false;
                                        speed = 150;
                                        break;
                                    }
                                    if (modeNum == 2)
                                    {
                                        gameModePrize = true;
                                        gameModeChangeSpeed = false;
                                        speed = 90;
                                        break;
                                    }
                                    if (modeNum == 3)
                                    {
                                        gameModePrize = false;
                                        gameModeChangeSpeed = true;
                                        speed = 100;
                                        break;
                                    }
                                }
                            }
                        }
                        if (iNum == 2)
                        {

                            while (true)
                            {
                                string dificultyNumber;
                                Console.Clear();
                                Console.WriteLine(new string('-', 50));
                                Console.SetCursorPosition(20, 1);
                                Console.WriteLine("Settings");
                                Console.WriteLine(new string('-', 50));
                                Console.WriteLine("1: Easy");
                                Console.WriteLine("2: Medium");
                                Console.WriteLine("3: Hard");
                                Console.Write("Enter number to choose menu:");
                                dificultyNumber = Console.ReadLine();
                                if (int.TryParse(dificultyNumber, out int difNum))
                                {
                                    if (difNum == 1)
                                    {
                                        speed = 200;
                                        break;
                                    }
                                    if (difNum == 2)
                                    {
                                        speed = 90;
                                        break;
                                    }
                                    if (difNum == 3)
                                    {
                                        speed = 50;
                                        break;
                                    }
                                }
                            }
                        }
                        if (iNum == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                        }
                        if (iNum == 4)
                        {
                            Console.Clear();
                            Console.WriteLine(new string('-', 60));
                            Console.SetCursorPosition(20, 1);
                            Console.WriteLine("Help");
                            Console.WriteLine(new string('-', 60));
                            Console.WriteLine("Snake is most populat game in the world \nand main aim to collect fruits without collapce anywhere");
                            Console.WriteLine("\nYou can control Snake with Arrow (Up, Down, Left, Right)\n and with Letters (A,S,D,W)");
                            Console.WriteLine("\nAnd Hot Key: 'p' = Pause, 'Esc' = Go to Main Menu, 'shift+anyKey'\n = speed up");
                            Console.WriteLine("\nEnter any key to close this menu");
                            Console.ReadKey();
                        }
                        if (iNum == 5)
                        {
                            isExit = true;
                            break;
                        }
                    }
                }
                if (isExit)
                {
                    break;
                }
                //**********************     End of Menu   *******************************
                //********************** Start Game Process *******************************
                int CurrentMapNumber = 0;
                int score = 0;
                int life = 0;
                int nextLevel = 120;
                Console.CursorVisible = false;
                while (true)
                {
                    Map map = new Map(CurrentMapNumber);
                    map.WriteBoard();
                    Control control = new Control();
                    Snake snake = new Snake(map.HeightMap, map.WidthMap, map.CurrentMapBarrier, gameModePrize);
                    snake.Direction = "Right";
                    snake.Life = life;
                    snake.Score = score;
                    int defaultSpeed = speed;
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        map.WriteBoard();
                        control.Input();
                        snake.Logic();
                        for (int i = 0; i < snake.SnakeX.Length; i++)
                        {
                            Console.SetCursorPosition(snake.SnakeX[i], snake.SnakeY[i]);
                            Console.Write("$");
                            Console.SetCursorPosition(snake.FruitX, snake.FruitY);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("@");
                            if (snake.isGameModeWithPrizes)
                            {
                                if (snake.PrizeX != null && snake.PrizeY != null)
                                {
                                    Console.SetCursorPosition(snake.PrizeX ?? 0, snake.PrizeY ?? 0);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("*");
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        snake.Direction = control.Key;
                        if (snake.isExitToMenu)
                        {
                            break;
                        }
                        int flag = 1;
                        while (snake.isPause)
                        {
                            if (flag == 1)
                            {
                                Console.Clear();
                                Console.WriteLine(new string('-', 50));
                                Console.SetCursorPosition(20, 1);
                                Console.WriteLine("Pause");
                                Console.WriteLine(new string('-', 50));
                                flag = 0;
                            }
                            control.Input();
                            if (control.Key == "Up" || control.Key == "Down" || control.Key == "Right" || control.Key == "Left")
                            {
                                snake.Direction = "Pause";
                                snake.Direction = control.Key;
                                break;
                            }
                        }

                        if (control.isDownShift)
                        {
                            speed = 70;
                        }
                        else
                        {
                            speed = defaultSpeed;
                        }
                        if (gameModeChangeSpeed)
                        {
                            int rnd = random.Next(30, 120);
                            speed = rnd;
                        }
                        Console.SetCursorPosition(0, map.HeightMap+1);
                        Console.WriteLine("Score: "+snake.Score.ToString());
                        if (gameModePrize)
                        {
                            Console.WriteLine("Life: " + snake.Life.ToString());
                            Console.Write("Prize: " + snake.StepToAccessPrize.ToString());
                        }
                        Thread.Sleep(speed);
                        if (snake.Score == nextLevel)
                        {
                            nextLevel += 120;
                            score = snake.Score;
                            life = snake.Life;
                            Console.Clear();
                            Console.WriteLine(new string('-', 50));
                            Console.SetCursorPosition(10, 1);
                            Console.WriteLine("Next Level enter any key to continue");
                            Console.WriteLine(new string('-', 50));
                            Console.ReadKey();
                            CurrentMapNumber++;
                            if (CurrentMapNumber == 4)
                            {
                                CurrentMapNumber = 0;
                            }
                            break;
                        }
                        if (!snake.isAlive)
                        {
                            life--;
                            break;
                        }
                        if (snake.isGameOver)
                        {
                            Console.Clear();
                            Console.WriteLine(new string('-', 60));
                            Console.SetCursorPosition(20, 1);
                            Console.WriteLine("GameOver");
                            Console.WriteLine(new string('-', 60));
                            Console.WriteLine("Your Score:" + snake.Score.ToString());
                            Console.WriteLine("Press Enter to go main menu");
                            Console.ReadLine();
                            break;
                        }
                    }
                    if (snake.isGameOver)
                    {
                        break;
                    }
                    if (snake.isExitToMenu)
                    {
                        break;
                    }
                }
            }
        }
    }
}
