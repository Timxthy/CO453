using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Timothy Arole version 0.1
    /// </author>

    ///<summary>
    /// 
    ///</summary>





    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public double miles { get; set; }

        public double feet { get; set; }

        public double meters { get; set; }
    


    public void DisplayMenu()
    {
            OutputHeading();

        string[] choices = { "MilesToFeet", "FeetToMiles", "MilesToMeters", };
        int choiceNo = ConsoleHelper.MakeChoice(choices);

            if (choiceNo == 1)
            {
                MilesToFeet();

            }
            else if (choiceNo == 2)
            {
                FeetToMiles();
            }
            else if (choiceNo == 3)
            {
                MilesToMeters();
            }
               
    }


       


        public void MilesToFeet()
        {
           
            Console.WriteLine("Converting Miles to Feet.");
            Console.WriteLine();
            ///Input value
            CalculateFeet();
            OutputFeet();

        }

        public void FeetToMiles()
        {
           
            Console.WriteLine("Converting Feet to Miles.");
            Console.WriteLine();
           ///input value
            CalculateMiles();
            OutputMiles();

        }

        public void MilesToMeters()
        {
          
            Console.WriteLine("Converting Miles to Meters.");
            Console.WriteLine();
            InputMiles();
            CalculateMeters();
            OutputMeters();

        }           




        private void OutputHeading()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("       Distance Converter");
            Console.WriteLine("    By Timothy Arole");
            Console.WriteLine("------------------------------------");
        }



        ///<summary>
        /// Prompt user to enter distance in miles 
        /// Input miles as double number
        ///</summary>

        private void InputMiles()
        {
            Console.Write("Please enter the amount of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        ///<summary>
        /// Prompt user to enter distance in Meters
        ///</summary>
        private void InputMeters()
        {
        Console.Write("Please enter the number of meters > ");
        string value = Console.ReadLine();
        meters = Convert.ToDouble(value);

        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }




        ///<summary>
        ///  Outputs Feet
        ///</summary>
        public void OutputFeet()
        {
            Console.WriteLine(miles + "miles is" + feet + "feet.");

        }

        ///<summary>
        ///  Outputs Miles
        ///</summary>
        public void OutputMiles()
        {
            Console.WriteLine(feet + "feet is" + miles + "miles.");

        }

        ///<summary>
        /// Outputs Meters
        ///</summary>
        public void OutputMeters()
        {
            Console.WriteLine(miles + "miles is" + meters + "meters.");

        }


        ///<summary>
        /// Calculates Miles
        ///</summary>
        public void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }


        ///<summary>
        /// Calculates Feet
        ///</summary>
        public void CalculateFeet()
        {
            feet = miles * 5280; 
        }

        ///<summary>
        /// Calculates Meters 
        ///</summary>
        public void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }

    }
}
