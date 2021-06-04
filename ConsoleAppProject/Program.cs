using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App06;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Timothy A 1/2/2021
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        private static StudentGrades grades = new StudentGrades();





        public static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();



            ///Experiemnt with menu for app 1




            ///Class name - Object name(think of one: unique) = new class name ();
            ///

            int choiceNo;

            do
            {
                string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks", "NetworkApp", "RPS - Game", "Quit" };
                choiceNo = ConsoleHelper.MakeChoice(choices);

                if (choiceNo == 1)
                {
                    DistanceConverter converter = new DistanceConverter();
                    converter.DisplayMenu();
                }
                else if (choiceNo == 2)
                {
                    BMI bmi = new BMI();
                    bmi.DisplayMenu();
                }
                else if (choiceNo == 3)
                {
                    StudentGrades sg = new StudentGrades();
                    sg.run();
                }
                else if (choiceNo == 4)
                {
                    NetworkApp myspace = new NetworkApp();
                    myspace.DisplayMenu();
                }
                else if (choiceNo == 5)
                {
                    GameView game = new GameView();
                    game.StartGame();
                }
                else if (choiceNo == 6)
                {
                    Console.WriteLine("Exiting the Apllication");
                }

                else Console.WriteLine("Invalid Choice !");
            }
            while (choiceNo != 6);
        }
    }
}


