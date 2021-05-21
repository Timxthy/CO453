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

        public char[] Grades { get; set; }

        public double Mean { get; set; }

        public int MinMark { get; set; }

        public int MaxMark { get; set; }



        /// <summary>
        /// run method
        /// </summary>
        public void run()
        {
            DisplayMenu();
        }



        /// <summary>
        /// provide the input
        ///- [Calculate methods]
        /// and check that the values given are correct
        /// </summary>

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            OutputMarks();
            CalculateStats();
            OutputStats();
            CalculateGradeProfile();

        }

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
            
            Marks = new int[Students.Length];

            for (int i = 0; i < Students.Length; i++)
            {
                Mark = (int)ConsoleHelper.InputNumber("Please enter a mark for the student " + Students[i] + " " + (i + 1) + ": ");

                Marks[i] = Mark;
            }

            Console.WriteLine("\nYou have entered the mark for the students. \n");
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
            OutputMean();
            OutputMinimum();
            OutputMaximum();
        }

        
        public void OutputMean()
        {
            CalculateStats();
            Console.Write(" \nThe mean mark is " + $"{Mean}");
        }

        private void OutputMinimum()
        {
            CalculateStats();
            Console.Write(" \nThe lowest Mark is " + $"{MinMark}");
        }

        private void OutputMaximum()
        {
            CalculateStats();
            Console.Write(" \nThe highest Mark is " + $"{MaxMark}");
        }


        private void CalculateGradeProfile()
        {
            for(int i = 0; i < 10; i++)
            {
                if (Marks[i] < 40)
                    Grades[i] = 'F';
                else if (Marks[i] < 50)
                    Grades[i] = 'D';
                else if (Marks[i] < 60)
                    Grades[i] = 'C';
                else if (Marks[i] < 70)
                    Grades[i] = 'B';
                else if (Marks[i] < 100)
                    Grades[i] = 'A';

                        

            }

        }



        internal void TestGradesEnumeration()
        {



        }






    }

}
    
