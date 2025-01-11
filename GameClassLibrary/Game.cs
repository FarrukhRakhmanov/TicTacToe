/*
 * Game.cs
 * Game class for the game
 * Revision History
 * Farrukh Rakhmanov, Valentine Ohalebo, 2024.09.19: Created
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class Game
    {
		#region fields
		private int round;
		private ScoreBoard scoreBoard;
		#endregion

		#region properties
		public int Round
		{
			get
			{
				return round;
			}
			set
			{
				round = value;
			}
		}
		public ScoreBoard ScoreBoard
		{
			get
			{
				return scoreBoard;
			}
			set
			{
				scoreBoard = value;
			}
		}

		#endregion

		#region custom constructor
		public Game()
        {
            Round = 1;
            ScoreBoard = new ScoreBoard();
        }
		#endregion
	}
}
