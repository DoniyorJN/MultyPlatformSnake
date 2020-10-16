using System;
using System.Drawing;
using System.Windows.Forms;
using Reptile;
namespace SnakeWinForm
{
    public partial class Form1 : Form
    {
        public static Form1 Self;
        public Graphics graphics;
        static bool gameModePrize = false;

        private int CurrentMapNumber = 0;
        private int score = 0;
        private int life = 0;
        private int nextLevel = 120;
        private int defaultInterval;

        private Map map;
        private Snake snake;
        private Control control;

        Random random = new Random();
        public Form1()
        {
            Self = this;
            InitializeComponent();
            this.Focus();
            this.KeyPreview = true;
            stopButton.Enabled = false;
        }

        private void StartGame()
        {
            map = new Map(CurrentMapNumber);
            if (withPrizesRadioButton.Checked) { gameModePrize = true; }
            else { gameModePrize = false; }

            snake = new Snake(map.HeightMap, map.WidthMap, map.CurrentMapBarrier, gameModePrize);
            control = new Control();
            control.Input("Right");
            pictureBox.Image = new Bitmap(Self.pictureBox.Width, Self.pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);
            snake.Life = life;
            snake.Score = score;


            if (easyRadioButton.Checked) timer1.Interval = 150;
            if (mediumRadioButton.Checked) timer1.Interval = 100;
            if(hardRadioButton.Checked) timer1.Interval = 50;

            defaultInterval = timer1.Interval;
            startButton.Enabled = false;
            gameModeGroupBox.Enabled = false;
            DifOfGameGroupBox.Enabled = false;
            stopButton.Enabled = true;
            timer1.Start();
        }
        
        private void DrawSnakeGame()
        {
            map.WriteBoard();
            snake.Logic();
            for (int i = 0; i < snake.SnakeX.Length; i++)
            {
                graphics.FillRectangle(Brushes.Green, snake.SnakeX[i] * map.SIZE, snake.SnakeY[i] * map.SIZE, map.SIZE, map.SIZE);
                graphics.FillRectangle(Brushes.Crimson, snake.FruitX * map.SIZE, snake.FruitY * map.SIZE, map.SIZE, map.SIZE);
                if (snake.isGameModeWithPrizes)
                {
                    if (snake.PrizeX != null && snake.PrizeY != null)
                    {
                        graphics.FillRectangle(Brushes.Gold, (snake.PrizeX ?? 1) * map.SIZE, (snake.PrizeY ?? 1) * map.SIZE, map.SIZE, map.SIZE);
                    }
                }
                
            }
            pictureBox.Refresh();
            snake.Direction = control.Key;
            //this.Focus();
            //this.KeyPreview = true;
        }
        private void NextLevel()
        {
            if (snake.Score == nextLevel)
            {
                nextLevel += 120;
                score = snake.Score;
                life = snake.Life;

                CurrentMapNumber++;
                if (CurrentMapNumber == 4)
                {
                    CurrentMapNumber = 0;
                }
                StartGame();
            }
            if (!snake.isAlive)
            {
                life--;
                StartGame();
            }
        }
        private void EndGame()
        {
            startButton.Enabled = true;
            gameModeGroupBox.Enabled = true;
            DifOfGameGroupBox.Enabled = true;
            stopButton.Enabled = false;
            graphics.Clear(Color.Gray);
            pictureBox.Refresh();
            CurrentMapNumber = 0;
            score = 0;
            life = 0;
            nextLevel = 120;
            timer1.Stop();
        }
        private void GameOver()
        {
            if (snake.isGameOver)
            {
                EndGame();
            }
        }
        private void DownShift()
        {
            if (control.isDownShift)
            {
                timer1.Interval = 50;
            }
            else
            {
                timer1.Interval = defaultInterval;
            }
        }
        private void Pause()
        {

            if (snake.isPause)
            {
                timer2.Start();
                timer1.Stop();
                if (control.Key == "Up" || control.Key == "Down" || control.Key == "Right" || control.Key == "Left")
                {
                    snake.Direction = "Pause";
                    snake.Direction = control.Key;
                    timer2.Stop();
                    timer1.Start();
                }
            }
        }
        private void Exit()
        {
            if (snake.isExitToMenu)
            {
                EndGame();
            }
        }

        //**********************************************************
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (changeSpeedRadioButton.Checked)
            {
                timer1.Interval = random.Next(40, 110);
            }
            DrawSnakeGame();
            NextLevel();
            DownShift();
            Pause();
            Exit();
            GameOver();
            scoreLabel.Text = snake.Score.ToString();
            lifeLabel.Text = snake.Life.ToString();
            prizeLabel.Text = snake.StepToAccessPrize.ToString();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            control.Input(e.KeyCode.ToString());
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Pause();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "ShiftKey")
            {
                control.isDownShift = false;
            }
        }
    }
}