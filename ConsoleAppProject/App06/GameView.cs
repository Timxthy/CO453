using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App06
{
    public class GameView
    {
        private Game game;


        public void StartGame()
        {
            SetUpConsole();

            ConsoleHelper.OutputHeading("   Rock, Paper Scissors Game");

            if(game == null)
            {
                Console.Write("Please enter your name!");

                string name = Console.ReadLine();

                game = new Game("T");
            }

           game.Start();

        }

        public void PlayGame()
        {

        }

        private void SetUpConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
        }

        

        public void GetPlayerChoice()
        {

        }

        public void ShowComputerChoice()
        {

        }

        public void ShowRoundScores()
        {

        }

        public void ShowWinner()
        {

        }

        public void EndGame()
        {

        }





    }
}
