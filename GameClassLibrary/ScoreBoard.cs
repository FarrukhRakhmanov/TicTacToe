/*
 * ScoreBoard.cs
 * ScoreBoard class for the game
 * Revision History
 * Farrukh Rakhmanov, Valentine Ohalebo, 2024.09.19: Created
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class ScoreBoard
    {
		#region fields
		private Player playerO;
		private Player playerX;
		#endregion

		#region properties
		public Player PlayerO
		{
			get
			{
				return playerO;
			}
			set
			{
				playerO = value;
			}
		}
        public Player PlayerX
		{
			get
			{
				return playerX;
			}
			set
			{
				playerX = value;
			}
		}
		#endregion

		#region custom constructor
		public ScoreBoard()
        {
            PlayerO = new Player();
            PlayerX = new Player();
        }
		#endregion
	}
}
