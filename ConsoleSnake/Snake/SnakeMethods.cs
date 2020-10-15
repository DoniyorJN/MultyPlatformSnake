using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reptile
{
    public partial class Snake
    {
        public string Direction
        {
            private get
            { return direction; }
            set
            {
                if (direction == string.Empty || value == "Escape" || value == "Pause")
                {
                    if (value == "Up")
                    {
                        direction = value;
                    }
                    else if (value == "Down")
                    {
                        direction = value;
                    }
                    else if (value == "Left")
                    {
                        direction = value;
                    }
                    else if (value == "Right")
                    {
                        direction = value;
                    }
                    else if (value == "Escape")
                    {
                        isExitToMenu = true;
                        direction = string.Empty;
                    }
                    else if (value == "Pause")
                    {
                        if (isPause)
                        {
                            isPause = false;
                            Direction = string.Empty;
                        }
                        else
                        {
                            isPause = true;
                            Direction = string.Empty;
                        }
                    }
                }
                else if (value == "Up" || value == "Down" || value == "Left" || value == "Right")
                {

                    if (direction == "Up" && value != "Down")
                    {
                        direction = value;
                    }
                    else if (direction == "Down" && value != "Up")
                    {
                        direction = value;
                    }
                    else if (direction == "Left" && value != "Right")
                    {
                        direction = value;
                    }
                    else if (direction == "Right" && value != "Left")
                    {
                        direction = value;
                    }
                }
            }
        }
        private void controlMovement()
        {
            switch (this.direction)
            {
                case "Up":
                    Y[0]--;
                    Y[0] = (Y[0] + heigth) % heigth;
                    break;
                case "Down":
                    Y[0]++;
                    Y[0] = (Y[0] + heigth) % heigth;
                    break;
                case "Right":
                    X[0]++;
                    X[0] = (X[0] + width) % width;
                    break;
                case "Left":
                    X[0]--;
                    X[0] = (X[0] + width) % width;
                    break;
            }
        }
        //for Initial position snake. Don't creat in start position
        private void creatFruit(int startPositionX, int startPositionY)
        {
            bool checkRand;
            do
            {
                checkRand = false;
                FruitX = random.Next(0, width);
                FruitY = random.Next(0, heigth);
                for (int i = 0; i < mapBarrierPoints.GetLength(0); i++)
                {
                    if ((mapBarrierPoints[i, 0] == FruitX && mapBarrierPoints[i, 1] == FruitY) ||
                        (startPositionX == FruitX && startPositionY == FruitY))
                    {
                        checkRand = true;
                    }

                }
            } while (checkRand);
        }
        private void creatFruit()
        {
            bool checkRand;
            do
            {
                checkRand = false;
                FruitX = random.Next(0, width);
                FruitY = random.Next(0, heigth);
                for (int i = 0; i < mapBarrierPoints.GetLength(0); i++)
                {
                    if (mapBarrierPoints[i, 0] == FruitX && mapBarrierPoints[i, 1] == FruitY)
                    {
                        checkRand = true;
                    }
                }
                for (int i = parts; i > 0; i--)
                {
                    if (X[i] == FruitX && Y[i] == FruitY)
                    {
                        checkRand = true;
                    }
                }
            } while (checkRand);
        }
        private void creatPrize()
        {
            bool checkRand;
            do
            {
                checkRand = false;
                PrizeX = random.Next(0, width);
                PrizeY = random.Next(0, heigth);
                for (int i = 0; i < mapBarrierPoints.GetLength(0); i++)
                {
                    if (mapBarrierPoints[i, 0] == PrizeX && mapBarrierPoints[i, 1] == PrizeY)
                    {
                        checkRand = true;
                    }
                }
                for (int i = parts; i > 0; i--)
                {
                    if (X[i] == PrizeX && Y[i] == PrizeY)
                    {
                        checkRand = true;
                    }
                }
            } while (checkRand);
        }
    }
}
