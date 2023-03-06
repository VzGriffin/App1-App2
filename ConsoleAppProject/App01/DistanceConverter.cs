using System;

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

        private double miles;

        private double feet;

        /// This offers
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// This offers
        private void InputMiles()
        {
            Console.Write("Please enter the number of Miles");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// This offers
        private void CalculateFeet()
        {

        }
        /// This offers
        private void OutputFeet()
        {

        }
    }
}
