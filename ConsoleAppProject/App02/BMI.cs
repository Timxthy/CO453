using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Timothy Arole version 0.1
    /// </author>
    public class BMI
    {
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResults;

        public string[] MenuChoices = { METRIC, IMPERIAL };

        public double INDEX;

        public const double UNDERWEIGHT = 18.5;
        public const double NORMALWEIGHT = 24.9;
        public const double OVERWEIGHT = 29.9;

        public const double OBESEWEIGHT1 = 34.9;
        public const double OBESEWEIGHT2 = 39.9;
        public const double OBESEWEIGHT3 = 40.0;


        /// <summary>
        /// attempt but i dont really think a display menu is needed for a BMI
        /// </summary>

        public void DisplayMenu()
        {
            PrintHeading();
            GetUnit();
            OutputUnit();
            GetWeight();
            GetHeight();

            string[] choices = { "1", "2", "----", };
            int choiceNo = ConsoleHelper.MakeChoice(choices);

            if (choiceNo == 1)
            {
                CalculateBMI();

            }
            else if (choiceNo == 2)
            {
                IndexCaluclate();
            }

            OutputResult();

        }

        


        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }


        public void OutputUnit()
        {
            Console.WriteLine("Please Chose between the given options: ");
            ConsoleHelper.OutputMenu(MenuChoices);

        }

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter specified weight in KGs: ");
                weight = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Please enter specified weight in Stones: ");
                double stones = Convert.ToDouble(Console.ReadLine());
                weight = stones * 14;
                Console.WriteLine("Please enter specified weight in Pounds: ");
                double pounds = Convert.ToDouble(Console.ReadLine());
                weight += pounds;
            }
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter specified height in CMs: ");
                height = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Please enter specified number of Feet: ");
                double feet = Convert.ToDouble(Console.ReadLine());
                height = feet * 12;
                Console.WriteLine("Please enter specified number of Inches: ");
                double inches = Convert.ToDouble(Console.ReadLine());
                height += inches;
            }
            return height;
        }

        public void CalculateBMI()
        {
            if (SelectedUnit == METRIC)
            {
                bmiResults = (weight / height / height) * 10000;
            }
            if (SelectedUnit == IMPERIAL)
            {
                bmiResults = (weight * 703) / (height * height);
            }
        }

        public void IndexCaluclate()
        {
            INDEX = bmiResults;
        }

        public void OutputResult()
        {
            Console.WriteLine(SelectedUnit);

            if (bmiResults < UNDERWEIGHT)
            {
                Console.WriteLine("Your BMI is: " + bmiResults
                    + "\nThe result of the BMI: Underweight!");
            }
            else if (bmiResults < NORMALWEIGHT)
            {
                Console.WriteLine("Your BMI is: " + bmiResults
                    + "\nThe result of the BMI: Healthy - Within the normal range");
            }
            else if (bmiResults < OVERWEIGHT)
            {
                Console.WriteLine("Your BMI is: " + bmiResults
                    + "\nThe result of the BMI: Overweight! ");
            }
            else if (bmiResults < OBESEWEIGHT1)
            {
                Console.WriteLine("Your BMI is: " + bmiResults
                    + "\nThe result of the BMI: Very Overweight!");
            }
            else if (bmiResults < OBESEWEIGHT2)
            {
                Console.WriteLine("Your BMI is: " + bmiResults
                    + "\nThe result of the BMI: Obese!");
            }
            else if (bmiResults >= OBESEWEIGHT3)
            {
                Console.WriteLine("Your BMI is: " + bmiResults
                    + "\nThe result of the BMI: BludClart Diabetic!!");
            }
        }

        public void PrintHeading()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
        }




    }
}
