/*
 * Player.cs
 * Player class for the game
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
    public class Player
    {
		#region fields
		private int score;
		#endregion

		#region properties
		public int Score
		{
			get
			{
				return score;
			}
			set
			{
				score = value;
			}
		}
		#endregion

		#region custom constructor
		public Player()
        {
            Score = 0;
        }
		#endregion
	}
}
