namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			buttonStartNewGame = new Button();
			labelRound = new Label();
			label6 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			groupBox1 = new GroupBox();
			playerXwinnerPicture = new PictureBox();
			labelScorePlayer2 = new Label();
			playerOwinnerPicture = new PictureBox();
			labelScorePlayer1 = new Label();
			comboBoxGameGrid = new ComboBox();
			panelGameGrid = new Panel();
			buttonClose = new Button();
			label4 = new Label();
			groupBox2 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)playerXwinnerPicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)playerOwinnerPicture).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.White;
			label1.Font = new Font("Segoe UI", 10.125F);
			label1.Location = new Point(981, 15);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(260, 41);
			label1.TabIndex = 1;
			label1.Text = "Grid Size";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.BackColor = Color.WhiteSmoke;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(64, 0);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(153, 50);
			label2.TabIndex = 3;
			label2.Text = "Player 1";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.BackColor = Color.WhiteSmoke;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(57, 0);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(152, 50);
			label3.TabIndex = 4;
			label3.Text = "Player 2";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonStartNewGame
			// 
			buttonStartNewGame.BackColor = Color.LightSkyBlue;
			buttonStartNewGame.Font = new Font("Segoe UI", 10.125F);
			buttonStartNewGame.Location = new Point(1118, 791);
			buttonStartNewGame.Margin = new Padding(4);
			buttonStartNewGame.Name = "buttonStartNewGame";
			buttonStartNewGame.Size = new Size(344, 60);
			buttonStartNewGame.TabIndex = 7;
			buttonStartNewGame.Text = "Start New Game";
			buttonStartNewGame.UseVisualStyleBackColor = false;
			buttonStartNewGame.Click += buttonStartNewGame_Clicked;
			// 
			// labelRound
			// 
			labelRound.BackColor = Color.White;
			labelRound.Font = new Font("Segoe UI", 10.125F);
			labelRound.Location = new Point(1326, 93);
			labelRound.Margin = new Padding(4, 0, 4, 0);
			labelRound.Name = "labelRound";
			labelRound.Size = new Size(272, 45);
			labelRound.TabIndex = 9;
			labelRound.Text = "      ";
			labelRound.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.BackColor = Color.White;
			label6.Font = new Font("Segoe UI", 10.125F);
			label6.Location = new Point(981, 95);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(260, 45);
			label6.TabIndex = 10;
			label6.Text = "Round";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = Properties.Resources.Circle;
			pictureBox1.Location = new Point(110, 93);
			pictureBox1.Margin = new Padding(4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(65, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.Transparent;
			pictureBox2.Image = Properties.Resources.X;
			pictureBox2.Location = new Point(104, 93);
			pictureBox2.Margin = new Padding(4);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(65, 64);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 12;
			pictureBox2.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.White;
			groupBox1.Controls.Add(playerXwinnerPicture);
			groupBox1.Controls.Add(labelScorePlayer2);
			groupBox1.Controls.Add(pictureBox2);
			groupBox1.Controls.Add(label3);
			groupBox1.Font = new Font("Segoe UI", 10.125F);
			groupBox1.Location = new Point(1323, 276);
			groupBox1.Margin = new Padding(4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4);
			groupBox1.Size = new Size(272, 461);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			// 
			// playerXwinnerPicture
			// 
			playerXwinnerPicture.Location = new Point(81, 292);
			playerXwinnerPicture.Margin = new Padding(4);
			playerXwinnerPicture.Name = "playerXwinnerPicture";
			playerXwinnerPicture.Size = new Size(117, 115);
			playerXwinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			playerXwinnerPicture.TabIndex = 16;
			playerXwinnerPicture.TabStop = false;
			// 
			// labelScorePlayer2
			// 
			labelScorePlayer2.BackColor = Color.WhiteSmoke;
			labelScorePlayer2.Location = new Point(105, 210);
			labelScorePlayer2.Margin = new Padding(4, 0, 4, 0);
			labelScorePlayer2.Name = "labelScorePlayer2";
			labelScorePlayer2.Size = new Size(65, 32);
			labelScorePlayer2.TabIndex = 14;
			labelScorePlayer2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// playerOwinnerPicture
			// 
			playerOwinnerPicture.Location = new Point(84, 292);
			playerOwinnerPicture.Margin = new Padding(4);
			playerOwinnerPicture.Name = "playerOwinnerPicture";
			playerOwinnerPicture.Size = new Size(117, 115);
			playerOwinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			playerOwinnerPicture.TabIndex = 15;
			playerOwinnerPicture.TabStop = false;
			// 
			// labelScorePlayer1
			// 
			labelScorePlayer1.BackColor = Color.WhiteSmoke;
			labelScorePlayer1.Location = new Point(108, 210);
			labelScorePlayer1.Margin = new Padding(4, 0, 4, 0);
			labelScorePlayer1.Name = "labelScorePlayer1";
			labelScorePlayer1.Size = new Size(69, 32);
			labelScorePlayer1.TabIndex = 13;
			labelScorePlayer1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// comboBoxGameGrid
			// 
			comboBoxGameGrid.Font = new Font("Segoe UI", 10.125F);
			comboBoxGameGrid.FormattingEnabled = true;
			comboBoxGameGrid.Items.AddRange(new object[] { "3x3", "4x4", "5x5", "6x6", "7x7", "10x10" });
			comboBoxGameGrid.Location = new Point(1326, 14);
			comboBoxGameGrid.Margin = new Padding(4);
			comboBoxGameGrid.Name = "comboBoxGameGrid";
			comboBoxGameGrid.Size = new Size(272, 45);
			comboBoxGameGrid.TabIndex = 14;
			// 
			// panelGameGrid
			// 
			panelGameGrid.Location = new Point(13, 15);
			panelGameGrid.Margin = new Padding(4);
			panelGameGrid.Name = "panelGameGrid";
			panelGameGrid.Size = new Size(927, 942);
			panelGameGrid.TabIndex = 0;
			// 
			// buttonClose
			// 
			buttonClose.BackColor = Color.LightCoral;
			buttonClose.Font = new Font("Segoe UI", 10.125F);
			buttonClose.Location = new Point(1118, 882);
			buttonClose.Margin = new Padding(4);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(344, 55);
			buttonClose.TabIndex = 15;
			buttonClose.Text = "Exit";
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// label4
			// 
			label4.BackColor = Color.White;
			label4.Font = new Font("Segoe UI", 10.125F);
			label4.Location = new Point(1046, 189);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(504, 41);
			label4.TabIndex = 17;
			label4.Text = "Score Board";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.White;
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(playerOwinnerPicture);
			groupBox2.Controls.Add(pictureBox1);
			groupBox2.Controls.Add(labelScorePlayer1);
			groupBox2.Location = new Point(979, 276);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(272, 461);
			groupBox2.TabIndex = 18;
			groupBox2.TabStop = false;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(1661, 978);
			Controls.Add(panelGameGrid);
			Controls.Add(groupBox2);
			Controls.Add(label4);
			Controls.Add(buttonClose);
			Controls.Add(comboBoxGameGrid);
			Controls.Add(groupBox1);
			Controls.Add(label6);
			Controls.Add(labelRound);
			Controls.Add(buttonStartNewGame);
			Controls.Add(label1);
			Margin = new Padding(5);
			Name = "MainForm";
			Text = "Group#7_Rakhmanov_Ohalebo";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)playerXwinnerPicture).EndInit();
			((System.ComponentModel.ISupportInitialize)playerOwinnerPicture).EndInit();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonStartNewGame;
        private Label labelRound;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label labelScorePlayer2;
        private Label labelScorePlayer1;
        private ComboBox comboBoxGameGrid;
        private Panel panelGameGrid;
        private PictureBox playerXwinnerPicture;
        private PictureBox playerOwinnerPicture;
        private Button buttonClose;
        private Label label4;
		private GroupBox groupBox2;
	}
}