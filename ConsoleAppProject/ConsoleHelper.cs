using System;
namespace ConsoleAppProject.App01
{
    public class ConsoleHelper
    {
        public static void OutputMenu(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine(choiceNo + ". " + choice);
            }
        }

        public static int MakeChoice(string[] choices)
        {
            // Display all the choices

            DisplayChoices(choices);

            // Get the user's choice

            int choiceNo = (int)InputNumber("\n Please enter the number of your choice: ",
                                            1, choices.Length);
            return choiceNo;
        }

        private static int InputNumber(string v1, int v2, int length)
        {
            throw new NotImplementedException();
        }

        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }

    }
}
