namespace FindPathRobot
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitleTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnStopTime = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelTitlePlayer = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelTitleRobot = new System.Windows.Forms.Label();
            this.robotScore = new System.Windows.Forms.Label();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioBtnRobot = new System.Windows.Forms.RadioButton();
            this.radioBtnPlayer = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.separateLabel2 = new System.Windows.Forms.Label();
            this.panelRobot = new System.Windows.Forms.Panel();
            this.labelRobot = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxScore.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(627, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 1863);
            this.label1.TabIndex = 0;
            // 
            // labelTitleTime
            // 
            this.labelTitleTime.AutoSize = true;
            this.labelTitleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTime.Location = new System.Drawing.Point(644, 167);
            this.labelTitleTime.Name = "labelTitleTime";
            this.labelTitleTime.Size = new System.Drawing.Size(75, 29);
            this.labelTitleTime.TabIndex = 1;
            this.labelTitleTime.Text = "Time:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(712, 164);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(46, 32);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "0s";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStopTime
            // 
            this.btnStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTime.Location = new System.Drawing.Point(668, 319);
            this.btnStopTime.Name = "btnStopTime";
            this.btnStopTime.Size = new System.Drawing.Size(116, 74);
            this.btnStopTime.TabIndex = 2;
            this.btnStopTime.Text = "Stop Time";
            this.btnStopTime.UseVisualStyleBackColor = true;
            this.btnStopTime.Click += new System.EventHandler(this.btnStopTime_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(668, 580);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(116, 74);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPlayer
            // 
            this.panelPlayer.Location = new System.Drawing.Point(12, 12);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(600, 611);
            this.panelPlayer.TabIndex = 3;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(258, 632);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(87, 22);
            this.labelPlayer.TabIndex = 4;
            this.labelPlayer.Text = "PLAYER";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitlePlayer
            // 
            this.labelTitlePlayer.AutoSize = true;
            this.labelTitlePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePlayer.Location = new System.Drawing.Point(6, 44);
            this.labelTitlePlayer.Name = "labelTitlePlayer";
            this.labelTitlePlayer.Size = new System.Drawing.Size(73, 25);
            this.labelTitlePlayer.TabIndex = 1;
            this.labelTitlePlayer.Text = "Player:";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Blue;
            this.playerScore.Location = new System.Drawing.Point(77, 38);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(31, 32);
            this.playerScore.TabIndex = 1;
            this.playerScore.Text = "0";
            this.playerScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.labelTitleRobot);
            this.groupBoxScore.Controls.Add(this.robotScore);
            this.groupBoxScore.Controls.Add(this.labelTitlePlayer);
            this.groupBoxScore.Controls.Add(this.playerScore);
            this.groupBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxScore.Location = new System.Drawing.Point(642, 12);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(169, 130);
            this.groupBoxScore.TabIndex = 5;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Scores";
            // 
            // labelTitleRobot
            // 
            this.labelTitleRobot.AutoSize = true;
            this.labelTitleRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleRobot.Location = new System.Drawing.Point(6, 91);
            this.labelTitleRobot.Name = "labelTitleRobot";
            this.labelTitleRobot.Size = new System.Drawing.Size(69, 25);
            this.labelTitleRobot.TabIndex = 1;
            this.labelTitleRobot.Text = "Robot:";
            // 
            // robotScore
            // 
            this.robotScore.AutoSize = true;
            this.robotScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotScore.ForeColor = System.Drawing.Color.Green;
            this.robotScore.Location = new System.Drawing.Point(77, 85);
            this.robotScore.Name = "robotScore";
            this.robotScore.Size = new System.Drawing.Size(31, 32);
            this.robotScore.TabIndex = 1;
            this.robotScore.Text = "0";
            this.robotScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioBtnRobot);
            this.groupBoxMode.Controls.Add(this.radioBtnPlayer);
            this.groupBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.Location = new System.Drawing.Point(642, 428);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(169, 115);
            this.groupBoxMode.TabIndex = 6;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // radioBtnRobot
            // 
            this.radioBtnRobot.AutoSize = true;
            this.radioBtnRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRobot.Location = new System.Drawing.Point(11, 73);
            this.radioBtnRobot.Name = "radioBtnRobot";
            this.radioBtnRobot.Size = new System.Drawing.Size(95, 30);
            this.radioBtnRobot.TabIndex = 0;
            this.radioBtnRobot.TabStop = true;
            this.radioBtnRobot.Text = "Robot";
            this.radioBtnRobot.UseVisualStyleBackColor = true;
            // 
            // radioBtnPlayer
            // 
            this.radioBtnPlayer.AutoSize = true;
            this.radioBtnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPlayer.Location = new System.Drawing.Point(11, 37);
            this.radioBtnPlayer.Name = "radioBtnPlayer";
            this.radioBtnPlayer.Size = new System.Drawing.Size(99, 30);
            this.radioBtnPlayer.TabIndex = 0;
            this.radioBtnPlayer.TabStop = true;
            this.radioBtnPlayer.Text = "Player";
            this.radioBtnPlayer.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(668, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 74);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // separateLabel2
            // 
            this.separateLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separateLabel2.Location = new System.Drawing.Point(825, -20);
            this.separateLabel2.Name = "separateLabel2";
            this.separateLabel2.Size = new System.Drawing.Size(1, 1351);
            this.separateLabel2.TabIndex = 7;
            // 
            // panelRobot
            // 
            this.panelRobot.Location = new System.Drawing.Point(838, 12);
            this.panelRobot.Name = "panelRobot";
            this.panelRobot.Size = new System.Drawing.Size(600, 611);
            this.panelRobot.TabIndex = 3;
            // 
            // labelRobot
            // 
            this.labelRobot.AutoSize = true;
            this.labelRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRobot.Location = new System.Drawing.Point(1110, 634);
            this.labelRobot.Name = "labelRobot";
            this.labelRobot.Size = new System.Drawing.Size(80, 22);
            this.labelRobot.TabIndex = 4;
            this.labelRobot.Text = "ROBOT";
            this.labelRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 673);
            this.Controls.Add(this.panelRobot);
            this.Controls.Add(this.separateLabel2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.labelRobot);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnStopTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTitleTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimDuongRobot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitleTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btnStopTime;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label labelTitlePlayer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label labelTitleRobot;
        private System.Windows.Forms.Label robotScore;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioBtnRobot;
        private System.Windows.Forms.RadioButton radioBtnPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label separateLabel2;
        private System.Windows.Forms.Panel panelRobot;
        private System.Windows.Forms.Label labelRobot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

