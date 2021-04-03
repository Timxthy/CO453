using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03

{
   
    public class StudentGrades
    {
        // Constants (Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

       
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int MinMark { get; set; }

        public int MaxMark { get; set; }

       


     

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            OutputMarks();
            CalculateStats();
            OutputStats();
            CalculateGradeProfile();

        }

        internal void TestGradesEnumeration()
        {



        }

        private Grades ConvertToGrade(int mark)
        {
            
        }

        private void OutputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($" {Students[i]} {Marks[i]}");
            }
        }

        private void CalculateStats()
        {
            double total = 0;

            MinMark = Marks[0];
            MaxMark = Marks[0];

            foreach (int mark in Marks)
            {
                total = total + mark;
                if (mark > MaxMark) MaxMark = mark;
                if (mark < MinMark) MinMark = mark;
            }

            Mean = total / Marks.Length;
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

            Marks = new int[10];
            Students = new string[]
            {
                "Adrian","Anais", "Timothy",
                "Quavious", "Jamal","Yousef",
                "Khari", "Kiari", "Marshall",
                "Belcalis"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

            for (int i = 0; i < Students.Length; i++)
            {
                Mark = (int)ConsoleHelper.InputNumber("Please enter a mark for the student " + Students[i] + " " + (i + 1) + ": ");

                Marks[i] = Mark;
            }

            Console.WriteLine("\nYou have entered the mark for the students. \n");
        }



    }

}
    
