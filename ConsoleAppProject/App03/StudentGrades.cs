using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {

        /

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowsstGradeC = 50;
        public const int LowsstGradeB = 60;
        public const int LowsstGradeA = 70;
        public const int HighestMark = 100;

        //
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Daniel", "Dylan", "Eric",
                "Georgia", "Hasan", "Hamza",
                "Jack", "Liam", "Shan", "Shamial"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        //

        public void InputMarks()
        {
            throw new NotImplementedException();
        }


        ///

        ///

        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        ///

        ///


        public Grades ConvertToGrade(int mark)
        {
            if (mark < 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }


        ///

        ///

        public void CalculateStats()
        {
            double total = 0;

            foreach (int mark in Marks)
            {
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        ///

        ///

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }
    }


}

