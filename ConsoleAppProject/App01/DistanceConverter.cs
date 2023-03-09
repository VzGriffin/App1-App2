using System;
using System.Diagnostics.Metrics;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Myles version 0.6
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
            OutputHeading("Converting Miles To Feet");

            miles = InputDistance("Please enther number if miles > ");
            
            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet To Miles");

            feet = InputDistance("Please enther number if feet > ");

            CalculateMiles();

            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles To Metres");

            metres = InputDistance("Please enther number if metres > ");

            CalculateMetres();

            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// This offers
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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
        private void OutputDistance(
            double formDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {formDistance}  {fromUnit} is {toDistance} {toUnit}!");
        }

        private void OutputHeading(String promt)
        {
            Console.WriteLine("\n =================================================");
            Console.WriteLine("                                                  ");
            Console.WriteLine("               Distance Coverter!                 ");
            Console.WriteLine("               By Myles Griffiths                 ");
            Console.WriteLine("                                                  ");
            Console.WriteLine(" =================================================");

            Console.WriteLine(promt);
            Console.WriteLine();
        }
    }
}
