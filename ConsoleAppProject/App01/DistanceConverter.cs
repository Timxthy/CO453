using system;
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

        private double miles;

        private double feet;


        public void PrintHeading()
        {
            
        }


        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();

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
            string value = Conole.ReadLine();
            miles = Convert.ToDouble(value);

        }

        ///<summary>
        /// 
        ///</summary>
        private void CalculateFeet()
        {
            feet = miles * 5280; 

        }
        ///<summary>
        /// 
        ///</summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is" + feet + "feet.");

        }



    }
}
