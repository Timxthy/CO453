using System;
namespace ConsoleAppProject.App06
{
    public class Game
    {

        

        public String PlayerName { get; }

        public int PlayerScore { get; set; }

        public GameChoice PlayerChoice { get; set; }

        public GamePlayer CurrentPlayers { get; set; }

        public Player Human { get; }

        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }


        public GameChoice ComputerChoice { get; set; }

        private Random generator = new Random(55);


        public int ComputerScore { get; set; }

        public const int MAXIMUM_ROUND = 10;

        public int Round { get; set; }

        public int LastRound { get; set; }

        public String WinnerName { get; set; }



        public Game(string name)
        {
            Human = new Player(name, GamePlayer.Player);
            Computer = new Player("Computer", GamePlayer.Computer);

            Round = 0;

        }

        public void Start()
        {
            Round = 1;
            LastRound = 5;

            CurrentPlayer = Human;



            Human.Score = 0;
            Computer.Score = 0;

        }

        
        public void End()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
            }
            else Winner = null;
        }

        public void MakeComputerchoice()
        {
            int choice = generator.Next(1,4);

            switch (choice)
            {
                case 1: ComputerChoice = GameChoice.Rock; break;
                case 2: ComputerChoice = GameChoice.Paper; break;
                case 3: ComputerChoice = GameChoice.Scissors; break;


            }

        }

        public void ScoreRound()
        {
            if(Human.Choice == GameChoice.Rock && Computer.Choice == GameChoice.Paper)
            {
                Computer.Score += 2;
                Winner = Computer;

            }
            if (Round < LastRound) Round++;
            else End();

        }













    }
}
