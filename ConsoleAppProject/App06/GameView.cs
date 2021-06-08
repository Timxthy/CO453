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

            if (game == null)
            {
                Console.Write("Please enter your name!");

                string name = Console.ReadLine();

                game = new Game("T");
            }

            game.Start();

        }

        public void PlayGame()
        {
            bool wantToQuit = false;

            do
            {
                StartGame();

                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);

                game.MakeComputerChoice();
                ///ShowComputerChoice(game.Computer.Choice);

                game.ScoreRound();

                if (game.Round == game.LastRound)
                {
                    Console.WriteLine();

                    ShowWinner();

                }
            } while (!wantToQuit);

        }

        private void SetUpConsole()
        {
            /// Console.SetWindowSize(100, 40);
            /// Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
        }

        public void DisplayChoice(GameChoice choice)
        {
            if (choice == GameChoice.Scissors)
            {
                GameImages.DrawScissors(10, 10);
            }
            else if (choice == GameChoice.Rock)
            {
                GameImages.DrawRock(10, 10);
            }
            else if (choice == GameChoice.Paper)
            {
                GameImages.DrawPaper(10, 10);
            }

        }

        public void GetPlayerChoice()
        {
            Console.WriteLine("Please eneter your choice!");
            /// string stores text - and read line stores from keyboard
            string choice = Console.ReadLine();

            if (choice == "scissors")
            {
                game.PlayerChoice = GameChoice.Scissors;
            }
            else if (choice == "rock")
            {

            }
            else if (choice == "paper")
            {

            }



        }

        /// <summary>
        /// to alternate location of oppenent choice
        /// </summary>
        public void ShowComputerChoice(GamePlayer Computer, GameChoice choice)
        {
            if (choice == GameChoice.Scissors)
            {
                GameImages.DrawScissors(40, 40);
            }
            else if (choice == GameChoice.Rock)
            {
                GameImages.DrawRock(40, 40);
            }
            else if (choice == GameChoice.Paper)
            {
                GameImages.DrawPaper(40, 40);
            }
        }

        public void ShowRoundScores()
        {
            ///add.Human.Score;
            ///add.Computer.Score;


        }

        public void ShowWinner()
        {
            if (game.Human.Score > game.Computer.Score)
            {
                game.Winner = game.Human;
            }
            else if (game.Computer.Score > game.Human.Score)
            {
                game.Winner = game.Computer;
            }
        }

        public void EndGame()
        {
            string[] choices = new string[]
            {
                "Quit", "Play Again"
            };
            Console.WriteLine("Game has now Ended. Select whether " +
                             "     you would like to quit or play again.");
            bool wantToQuit = false;
            do
            {
                
                int choice = ConsoleHelper.MakeChoice(choices);
                switch (choice)
                {
                    case 1: wantToQuit = true; break;
                    case 2: PlayGame(); break;

                }
            } while (!wantToQuit);
        }





    }

}    

