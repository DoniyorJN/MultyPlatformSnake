using System;

namespace Reptile
{
    public partial class Snake
    { 
        private int heigth;
        private int width;
        private int parts = 1;
        private int[] X = new int[1000];
        private int[] Y = new int[1000];
        private string direction = string.Empty;
        private int[,] mapBarrierPoints;
        public int FruitX { get; private set; }
        public int FruitY { get; private set; }
        public int[] SnakeX { get; private set; }
        public int[] SnakeY { get; private set; }
        private bool isGameStart = true;  
        public bool isGameOver { get; private set; }
        public bool isExitToMenu { get; private set; }
        public bool isPause{ get; private set; }
        private int life;
        public int Life { get { return life; }
            set
            {
                if(value>=0 && value < 4)
                {
                    life = value;
                }
            }
        }
        public bool isAlive { get; private set; } = true;
        public int Score { get; set; }
        public bool isGameModeWithPrizes { get; set;}
        private int whenGivePrize;
        private int stepToAccessPrize = 40;
        public int? PrizeX { get; private set; } =null;
        public int? PrizeY { get; private set; } = null;

        Random random = new Random();
        public Snake(int heightMap,int widthMap, int[,] mapBarrier, bool prize=false, int startPositionX=1, int startPositionY = 1)
        {
            heigth = heightMap;
            width = widthMap;
            X[0] = startPositionX;
            Y[0] = startPositionY;
            isGameModeWithPrizes = prize;
            mapBarrierPoints = new int[mapBarrier.GetLength(0), 2];
            for(int i=0; i < mapBarrier.GetLength(0); i++)
            {
                mapBarrierPoints[i, 0] = mapBarrier[i, 0];
                mapBarrierPoints[i, 1] = mapBarrier[i, 1];
            }
            creatFruit(startPositionX, startPositionY);
            
        }
        public void Logic()
        {
            if (X[0] == FruitX && Y[0] == FruitY)
            {
                Score += 10;
                parts++;
                creatFruit();
            }
            //Create Prize
            if (isGameModeWithPrizes)
            {
                if (isGameStart)
                {
                    whenGivePrize = Score+50;
                    isGameStart = false;
                }
                if (whenGivePrize == Score)
                {
                    if (PrizeX == null && PrizeY == null)
                    {
                        creatPrize();
                        stepToAccessPrize = 0;
                    }
                }
                if (X[0] == PrizeX && Y[0] == PrizeY)
                {
                    int rnd = random.Next(2);
                    if (rnd == 0) { Score += 10; }
                    else if (rnd == 1 && life<4) { life++; }
                    Score += 10;
                    parts++;
                    stepToAccessPrize = 0;
                    PrizeX = null;
                    PrizeY = null;
                }
                if (stepToAccessPrize == 35)
                {
                    whenGivePrize += 50;
                    PrizeX = null;
                    PrizeY = null;
                }
                stepToAccessPrize++;
            }
            //End Creat Prize
            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
            controlMovement();
            //Copy coordinats for return outside to Draw
            SnakeX = new int[parts];
            SnakeY = new int[parts];
            for (int i = 0; i <= (parts - 1); i++)
            {
                SnakeX[i] = X[i];
                SnakeY[i] = Y[i];
            }
            //Check Collapce
            for (int i = parts; i > 1; i--)
            {
               if(X[0]==X[i] && Y[0] == Y[i])
                {
                    if (life >= 0) { life--; isAlive = false; }
                    else { isGameOver = true; }
                }
            }
            for (int i = 0; i < mapBarrierPoints.GetLength(0); i++)
            {
                if (mapBarrierPoints[i, 0] == X[0] && mapBarrierPoints[i, 1] == Y[0])
                {
                    if (life > 0) { life--; isAlive = false; }
                    else { isGameOver = true; }
                }
            }
        }
    }
}
