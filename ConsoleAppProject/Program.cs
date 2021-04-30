using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
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
            

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

           
            


            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks" };
            int choiceNo = ConsoleHelper.MakeChoice(choices);
           

            ///Class name - Object name(think of one: unique) = new class name ();
            ///


            if (choiceNo == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.run();
            }
            else if (choiceNo == 2)
            {
                BMI bmi = new BMI();
                bmi.run();
            }
            else if (choiceNo == 3)
            {
                StudentGrades sg = new StudentGrades();
                sg.run();
            }
            else if (choiceNo == 4)
            {
                
            }
            else Console.WriteLine("Invalid Choice !");
        }

        
    }
}


