namespace SnakeWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.DifOfGameGroupBox = new System.Windows.Forms.GroupBox();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.gameModeGroupBox = new System.Windows.Forms.GroupBox();
            this.changeSpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.withPrizesRadioButton = new System.Windows.Forms.RadioButton();
            this.classicRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DifOfGameGroupBox.SuspendLayout();
            this.gameModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.prizeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.stopButton);
            this.splitContainer1.Panel1.Controls.Add(this.lifeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.scoreLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.exitButton);
            this.splitContainer1.Panel1.Controls.Add(this.DifOfGameGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.gameModeGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.startButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 454);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 0;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prizeLabel.Location = new System.Drawing.Point(74, 300);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(0, 20);
            this.prizeLabel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Prize:";
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(10, 363);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(104, 40);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lifeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.lifeLabel.Location = new System.Drawing.Point(74, 268);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(19, 20);
            this.lifeLabel.TabIndex = 13;
            this.lifeLabel.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.scoreLabel.Location = new System.Drawing.Point(74, 237);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(19, 20);
            this.scoreLabel.TabIndex = 12;
            this.scoreLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Life:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score:";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(10, 409);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 40);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DifOfGameGroupBox
            // 
            this.DifOfGameGroupBox.Controls.Add(this.easyRadioButton);
            this.DifOfGameGroupBox.Controls.Add(this.mediumRadioButton);
            this.DifOfGameGroupBox.Controls.Add(this.hardRadioButton);
            this.DifOfGameGroupBox.Location = new System.Drawing.Point(9, 134);
            this.DifOfGameGroupBox.Name = "DifOfGameGroupBox";
            this.DifOfGameGroupBox.Size = new System.Drawing.Size(104, 100);
            this.DifOfGameGroupBox.TabIndex = 7;
            this.DifOfGameGroupBox.TabStop = false;
            this.DifOfGameGroupBox.Text = "Dificulty of Game";
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Checked = true;
            this.easyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(48, 17);
            this.easyRadioButton.TabIndex = 2;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(6, 42);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Location = new System.Drawing.Point(6, 65);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(48, 17);
            this.hardRadioButton.TabIndex = 0;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.Controls.Add(this.changeSpeedRadioButton);
            this.gameModeGroupBox.Controls.Add(this.withPrizesRadioButton);
            this.gameModeGroupBox.Controls.Add(this.classicRadioButton);
            this.gameModeGroupBox.Location = new System.Drawing.Point(10, 10);
            this.gameModeGroupBox.Name = "gameModeGroupBox";
            this.gameModeGroupBox.Size = new System.Drawing.Size(104, 100);
            this.gameModeGroupBox.TabIndex = 6;
            this.gameModeGroupBox.TabStop = false;
            this.gameModeGroupBox.Text = "Game Mode";
            // 
            // changeSpeedRadioButton
            // 
            this.changeSpeedRadioButton.AutoSize = true;
            this.changeSpeedRadioButton.Location = new System.Drawing.Point(6, 65);
            this.changeSpeedRadioButton.Name = "changeSpeedRadioButton";
            this.changeSpeedRadioButton.Size = new System.Drawing.Size(96, 17);
            this.changeSpeedRadioButton.TabIndex = 2;
            this.changeSpeedRadioButton.Text = "Change Speed";
            this.changeSpeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // withPrizesRadioButton
            // 
            this.withPrizesRadioButton.AutoSize = true;
            this.withPrizesRadioButton.Location = new System.Drawing.Point(6, 42);
            this.withPrizesRadioButton.Name = "withPrizesRadioButton";
            this.withPrizesRadioButton.Size = new System.Drawing.Size(78, 17);
            this.withPrizesRadioButton.TabIndex = 1;
            this.withPrizesRadioButton.Text = "With Prizes";
            this.withPrizesRadioButton.UseVisualStyleBackColor = true;
            // 
            // classicRadioButton
            // 
            this.classicRadioButton.AutoSize = true;
            this.classicRadioButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.classicRadioButton.Checked = true;
            this.classicRadioButton.Location = new System.Drawing.Point(6, 19);
            this.classicRadioButton.Name = "classicRadioButton";
            this.classicRadioButton.Size = new System.Drawing.Size(58, 17);
            this.classicRadioButton.TabIndex = 0;
            this.classicRadioButton.TabStop = true;
            this.classicRadioButton.Text = "Classic";
            this.classicRadioButton.UseVisualStyleBackColor = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(9, 323);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 40);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1025, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 454);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DifOfGameGroupBox.ResumeLayout(false);
            this.DifOfGameGroupBox.PerformLayout();
            this.gameModeGroupBox.ResumeLayout(false);
            this.gameModeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox gameModeGroupBox;
        private System.Windows.Forms.RadioButton changeSpeedRadioButton;
        private System.Windows.Forms.RadioButton withPrizesRadioButton;
        private System.Windows.Forms.RadioButton classicRadioButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox DifOfGameGroupBox;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prizeLabel;
    }
}

