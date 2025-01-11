/*
 * MainForm.cs
 * TicTacToe simple game main form
 * Revision History
 * Farrukh Rakhmanov, Valentine Ohalebo, 2024.09.19: Created
 * Farrukh Rakhmanov, Valentine Ohalebo, 2024.09.24: Revised UI and code refactoring
 * 
 */
using System;
using GameClassLibrary;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
	// Main form of the Tic-Tac-Toe game
	public partial class MainForm : Form
	{

		#region Global variables
		// Constants for grid positioning and size
		private const int INIT_TOP = 50;
		private const int INIT_LEFT = 50;
		private const int WIDTH = 80;
		private const int HEIGHT = 80;
		private const int VGAP = 15;
		private const int HGAP = 15;

		// Variables for grid and game setup
		private int numberOfRows = 3;
		private int index = 0;
		private PictureBox[,] gameGrid;

		// Images used in the game for players and winners
		private Bitmap circleImage;
		private Bitmap xImage;
		private Bitmap winnerImage;

		Game game = new Game();

		#endregion

		// Constructor initializes the form and grid
		public MainForm()
		{

			InitializeComponent();

			try
			{
				// Load images from embedded resources for Player O, Player X, and winner
				using (var ms = new MemoryStream(Resources.PlayerCircle))
				{
					circleImage = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.PlayerX))
				{
					xImage = new Bitmap(ms);
				}
				using (var ms = new MemoryStream(Resources.Winner))
				{
					winnerImage = new Bitmap(ms);
				}

				// Initialize the game grid with default size (3x3)
				InitializeGrid(numberOfRows);

				// Set up combo box for grid size selection and round label
				comboBoxGameGrid.Text = comboBoxGameGrid.Items[0]?.ToString();
				comboBoxGameGrid.SelectedIndexChanged += comboBoxGrid_SelectedIndexChanged;
				labelRound.Text = game.Round.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#region Built-in Event Handlers

		// Event handler for changing the grid size via combo box selection
		private void comboBoxGrid_SelectedIndexChanged(object sender, EventArgs e)
		{
			int gridSizeIndex = int.Parse(comboBoxGameGrid.SelectedIndex.ToString());
			switch (gridSizeIndex)
			{
				case 0:
					numberOfRows = 3;
					break;
				case 1:
					numberOfRows = 4;
					break;
				case 2:
					numberOfRows = 5;
					break;
				case 3:
					numberOfRows = 6;
					break;
				case 4:
					numberOfRows = 7;
					break;
				case 5:
					numberOfRows = 10;
					break;
			}
			ResetGame();
		}

		// Event handler for starting a new game when the "Start New Game" button is clicked
		private void buttonStartNewGame_Clicked(object sender, EventArgs e)
		{
			ResetGame();
		}

		// Event handler for when a grid cell (PictureBox) is clicked
		private void B_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			int indexI = 0;
			int indexJ = 0;

			// Find the clicked PictureBox in the grid
			try
			{
				for (int i = 0; i < gameGrid.GetLength(0); i++)
				{
					for (int j = 0; j < gameGrid.GetLength(1); j++)
					{
						if (gameGrid[i, j] == pictureBox)
						{
							indexI = i;
							indexJ = j;
						}
					}
				}

				// Check if the cell is empty before placing a marker (O or X)
				if (pictureBox != null && pictureBox.Image != circleImage & pictureBox.Image != xImage)
				{
					if (index++ % 2 == 0) // Player 1's turn (O)
					{
						pictureBox.Image = circleImage;
						gameGrid[indexI, indexJ] = pictureBox;
					}
					else // Player 2's turn (X)
					{
						pictureBox.Image = xImage;
						gameGrid[indexI, indexJ] = pictureBox; ;
					}
					CheckTheWinner(pictureBox);
					CheckDraw();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Close the form when the "Close" button is clicked
		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close(); // Close the application
		}

		#endregion

		#region Custom Methods
		
		/// <summary>
		/// Populates the panelGameGrid with PictureBox controls to create the game grid
		/// </summary>
		/// <param name="numberOfRows"> Takes numberOfRows int parameter</param>
		private void InitializeGrid(int numberOfRows)
		{
			gameGrid = new PictureBox[numberOfRows, numberOfRows]; // Create grid
			panelGameGrid.Controls.Clear(); // Clear any previous grid

			int x = INIT_LEFT;  // Starting X position for the grid
			int y = INIT_TOP;   // Starting Y position for the grid

			// Loop through the grid rows and columns to create PictureBox controls
			for (int i = 0; i < numberOfRows; i++)
			{
				for (int j = 0; j < numberOfRows; j++)
				{
					PictureBox pictureBox = new PictureBox
					{
						Left = x,                      // Set left position
						Top = y,                       // Set top position
						Width = WIDTH,                 // Set width
						Height = HEIGHT,               // Set height
						BackColor = Color.White,       // Set background color
						Name = i.ToString() + "," + j.ToString(), // Unique name for each PictureBox
						SizeMode = PictureBoxSizeMode.StretchImage // Set image size mode
					};

					panelGameGrid.Controls.Add(pictureBox);  // Add PictureBox to panel
					
					gameGrid[i, j] = pictureBox;             // Store PictureBox in grid array
					pictureBox.Click += B_Click;             // Set up click event for each PictureBox

					x += WIDTH + HGAP;  // Move to the next column
				}
				x = INIT_LEFT;          // Reset X position for new row
				y += HEIGHT + VGAP;     // Move to the next row
				index = 0;              // Reset turn index
			}
			
		}

		/// <summary>
		/// Check the winning conditions for the game
		/// </summary>
		/// param name="pictureBox"> Takes PictureBox pictureBox parameter to compare</param>
		private void CheckTheWinner(PictureBox pictureBox)
		{
			// Loop through rows, columns, and diagonals to check for a win
			try
			{
				for (int i = 0; i < gameGrid.GetLength(0); i++)
				{
					int countRow = 0;
					int countColumn = 0;
					int countDiagonalLeft = 0;
					int countDiagonalRight = 0;

					for (int j = 0; j < gameGrid.GetLength(1); j++)
					{
						if (gameGrid[i, j].Image == pictureBox.Image)
						{
							countRow++; // Check rows
						}
						if (gameGrid[j, i].Image == pictureBox.Image)
						{
							countColumn++; // Check columns
						}
						if (gameGrid[j, j].Image == pictureBox.Image)
						{
							countDiagonalLeft++; // Check diagonal (left to right)
						}
						if (gameGrid[j, (gameGrid.GetLength(0) - 1) - j].Image == pictureBox.Image)
						{
							countDiagonalRight++; // Check diagonal (right to left)
						}
					}

					// If a winning combination is found, show the winner
					if (countRow == gameGrid.GetLength(0) || 
						countColumn == gameGrid.GetLength(0) ||
						countDiagonalLeft == gameGrid.GetLength(0) || 
						countDiagonalRight == gameGrid.GetLength(0))
					{
						ShowTheWinner(pictureBox);
						break;
					}
					else
					{
						CheckDraw(); // Check for a draw
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Check if the game is a draw, do not take any parameters
		/// </summary>
		private void CheckDraw()
		{
			int allFilledCells = 0;

			// Count all filled cells

			try
			{
				for (int i = 0; i < gameGrid.GetLength(0); i++)
				{
					for (int j = 0; j < gameGrid.GetLength(1); j++)
					{
						if (gameGrid[i, j].Image != null)
						{
							allFilledCells++;
						}
					}
				}

				// If all cells are filled and no winner, declare a draw
				if (allFilledCells == gameGrid.GetLength(0) * gameGrid.GetLength(1))
				{
					ShowDraw();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Shows the winner of the game and resets the game grid
		/// </summary>
		/// <param name="pictureBox">Takes pictureBox parameter to identify the winner and prints according message</param>
		private void ShowTheWinner(PictureBox pictureBox)
		{
			if (pictureBox.Image == circleImage) // Player 1 wins
			{
				MessageBox.Show($"Player 1 has won this round!!!");
				labelScorePlayer1.Text = $"{++game.ScoreBoard.PlayerO.Score}";				
				AssingWinnerImage(); // Display winner's image
			}
			else if (pictureBox.Image == xImage) // Player 2 wins
			{
				MessageBox.Show($"Player 2 has won this round!!!");
				labelScorePlayer2.Text = $"{++game.ScoreBoard.PlayerX.Score}";				
				AssingWinnerImage(); // Display winner's image
			}

			labelRound.Text = $"{++game.Round}";
			InitializeGrid(numberOfRows); // Reset grid
		}

		/// <summary>
		/// Assigns the winner's image based on the current scores
		/// </summary>
		private void AssingWinnerImage()
		{
			if (game.ScoreBoard.PlayerO.Score > game.ScoreBoard.PlayerX.Score)
			{
				playerOwinnerPicture.Image = winnerImage;
				playerOwinnerPicture.Visible = true;
				playerXwinnerPicture.Visible = false;
			}
			else if (game.ScoreBoard.PlayerO.Score < game.ScoreBoard.PlayerX.Score)
			{
				playerXwinnerPicture.Image = winnerImage;
				playerXwinnerPicture.Visible = true;
				playerOwinnerPicture.Visible = false;
			}
		}

		/// <summary>
		/// Shows a message if the game is a draw
		/// </summary>
		private void ShowDraw()
		{
			MessageBox.Show("It's a draw in this round!!!");
			InitializeGrid(numberOfRows); 
			AssingWinnerImage();
			labelRound.Text = $"{++game.Round}"; 
			
		}
		/// <summary>
		/// Reset the game to start a new game
		/// </summary>
		private void ResetGame()
		{
			game = new Game(); 
			InitializeGrid(numberOfRows);
			labelScorePlayer1.Text = game.ScoreBoard.PlayerO.Score.ToString();
			labelScorePlayer2.Text = game.ScoreBoard.PlayerX.Score.ToString();
			labelRound.Text = game.Round.ToString();
			playerOwinnerPicture.Hide();
			playerXwinnerPicture.Hide();
		}
		#endregion
	}
}
