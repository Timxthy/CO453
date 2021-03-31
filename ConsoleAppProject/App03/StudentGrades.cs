using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03

{
    /// <summary>
    /// Application for converting marks into grades and calculating
    /// the mean, maximum and minimum mark that were entered.
    /// </summary>
    public class StudentGrades
    {
        // Constants (Boundaries)

        public const int LOWESTMARK = 0;
        public const int LOWESTGRADED = 40;
        public const int LOWESTGRADEC = 50;
        public const int LOWESTGRADEB = 60;
        public const int LOWESTGRADEA = 70;
        public const int HighestMark = 100;

        // Properties
        public string[] STUDENTS { get; set; }

        public int[] MARKS { get; set; }

        public int[] GradeProfile { get; set; }

        public double MEAN { get; set; }

        public int MINMARK { get; set; }

        public int MAXMARK { get; set; }

       

        /// <summary>
        /// Used by class diagram
        /// </summary>
        public Grades Grades
        {
            get => default;
            set
            {
            }
        }

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            OutputMarks();
            CalculateStats();
            OutputStats();
            CalculateGradeProfile();

        }

        private void OutputMarks()
        {
            throw new NotImplementedException();
        }

        private void CalculateStats()
        {
            throw new NotImplementedException();
        }

        private void OutputStats()
        {
            throw new NotImplementedException();
        }

        private void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Contains the 10 students and inputs the marks for all the students
        /// </summary>
        public void InputMarks()
        {
            int Mark;

            MARKS = new int[10];
            STUDENTS = new string[]
            {
                "Adrian","Anais", "Timothy",
                "Quavious", "Jamal","Yousef",
                "Khari", "Kiari", "Marshall",
                "Belcalis"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            MARKS = new int[STUDENTS.Length];

            for (int i = 0; i < STUDENTS.Length; i++)
            {
                Mark = (int)ConsoleHelper.InputNumber("Please enter a mark for the student " + STUDENTS[i] + " " + (i + 1) + ": ");

                MARKS[i] = Mark;
            }

            Console.WriteLine("\nYou have entered the mark for the students. \n");
        }



    }

}
    
