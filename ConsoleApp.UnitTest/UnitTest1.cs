using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.UnitTest
{
    [TestClass]
    public class TestDistanceConverter
    {
        DistanceConverter DC = new DistanceConverter();

        [TestMethod]
        public void TestMilesToFeet()
        {
           
            DC.miles = 10;
            DC.CalculateFeet();
            DC.OutputFeet();
            ///Assert is to check whether the test has passed.
            Assert.AreEqual(52800, DC.feet);
           

            /// cohesion = software engineering term - parts working together


        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DC.feet = 105600;
            DC.CalculateMiles();
            DC.OutputMiles();
            Assert.AreEqual(20, DC.miles);



            
        }

        [TestMethod]
        public void TestMilestoMeters()
        {
            DC.miles = 2;
            DC.CalculateMeters();
            DC.OutputMeters();
            Assert.AreEqual(3218.68, DC.meters);


        }

    }
}
