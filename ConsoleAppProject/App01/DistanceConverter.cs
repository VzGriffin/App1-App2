using System;
using System.Diagnostics.Metrics;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Myles version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// This offers
        public void MilesToFeet()
        {
            OutputHeading();
            Console.WriteLine("Converting Miles To Feet");
            Console.WriteLine();

            InputMiles ();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading();
            Console.WriteLine("Converting Feet To Miles");
            Console.WriteLine();

            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading();
            Console.WriteLine("Converting Miles To Metres");
            Console.WriteLine();

            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        /// This offers
        private void InputMiles()
        {
            Console.Write("Please enter the number of Miles");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of Feet");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }


        private void InputMetres()
        {
            Console.Write("Please enter the number of Metres");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }


            /// This offers
            private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

            private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METERS_IN_MILES;
        }

        /// This offers
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + " Feet!" );
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is " + miles + " miles!");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is " + metres + " metres!");
        }


        private void OutputHeading()
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("                                                  ");
            Console.WriteLine("               Distance Coverter!                 ");
            Console.WriteLine("                                                  ");
            Console.WriteLine(" =================================================");
        }
    }
}
