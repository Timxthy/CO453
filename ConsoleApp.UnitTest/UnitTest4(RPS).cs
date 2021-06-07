using ConsoleAppProject.App06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.UnitTest
{
    [TestClass]
    public class RPS_GameTests
    {
        private Game game = new Game("T");

        [TestMethod]
        public void TestGameStart()
        {
            game.Start();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(1, game.Round);

            Assert.AreEqual(GamePlayer.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual(0, game.Human.Score);

            Assert.AreEqual("T", game.Human.Name);
            Assert.AreEqual("Computer", game.Computer.Name);



        }

        [TestMethod]
        public void TestComputerChoiceIsRandom()
        {
            int[] choices = new int[4];

            game.Start();

            for (int i = 0; i < 10000; i++)
            {
                game.MakeComputerChoice();
                int choiceNo = (int)game.Computer.Choice;
                choices[choiceNo]++;

            }

            Assert.IsTrue(choices[0] == 0);
            Assert.IsTrue(choices[1] > 3000);
            Assert.IsTrue(choices[2] > 3000);
            Assert.IsTrue(choices[3] > 3000);

        }

        [TestMethod]
        public void TestScoreRoundRockPaper()
        {
            game.Start();

            game.Human.Choice = GameChoice.Rock;
            game.Computer.Choice = GameChoice.Paper;

            game.ScoreRound();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual(game.Winner.PlayerType, GamePlayer.Computer);

        }

    }

}
