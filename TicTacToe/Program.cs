/*
 * Program.cs
 * TicTacToe simple game 
 * Revision History
 * Farrukh Rakhmanov, Valentine Ohalebo, 2024.09.19: Created
 * Farrukh Rakhmanov, Valentine Ohalebo, 2024.09.24: Revised UI and code refactoring
 * 
 */
namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}