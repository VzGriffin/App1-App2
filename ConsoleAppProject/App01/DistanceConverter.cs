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

        public const double FEET_IN_METRES = 3.28084;

        public const string MILES = "miles";

        public const string FEET = "feet";

        public const string METRES = "metres";

        private double fromDistance;
        private double toDistance;
        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// This offers <summary>
        /// This offers
        /// 
        /// </summary>
        /// 
        public void ConvertDistacne()
        {
            OutputHeading();

            fromUnit = SelecUnit(" Select the from Distance unit > ");
            toUnit = SelecUnit(" Select the to Distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($" Enther number of {fromUnit} > ");
            
            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        private string SelecUnit(string prompt)
        {
            string choice = Displaychoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice) //75
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string Displaychoices(string promt)  
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(promt);
            string choice = Console.ReadLine();
            return choice;  
        }

        ///
        ///
        ///
        ///
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }


        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" {toDistance}  {toUnit}!\n");
        }


        ///
        ///
        ///
        ///
        ///
        private void OutputHeading()
        {
            Console.WriteLine("\n================================================");
            Console.WriteLine("                   Distance Converter             ");
            Console.WriteLine("                   by Myles Griffiths             ");
            Console.WriteLine(" =================================================\n");
            
        }
    }
}
