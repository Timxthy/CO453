using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App06
{
    public class Player
    {
        public string Name { get; }

        public int Score { get; set; }
        public GameChoice GameChoice { get; private set; }
        public GamePlayer PlayerType { get; }

        public GameChoice Choice { get; set; }


        public Player(string name, GamePlayer playerType)
        {
            this.Name = name;
            this.PlayerType = playerType;
            Score = 0;
            GameChoice = GameChoice.None;

        }

    }
}
