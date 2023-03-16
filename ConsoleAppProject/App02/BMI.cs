using System;
using System.Diagnostics.Metrics;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {

        public void CalculateIndex()
        {
            Console.WriteLine("\n================================================");
            Console.WriteLine("                    BMi calculator                ");
            Console.WriteLine("                   by Myles Griffiths             ");
            Console.WriteLine(" =================================================\n");


            Console.WriteLine("\n");
            Console.WriteLine("Enter your Waght (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height (m) ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (height * height);
            Console.WriteLine("Your BMI is:" + Math.Round(BMI, 2));
            Console.ReadKey();

            if (BMI < 16)
                Console.WriteLine("You are Severly Underweight");
            else
                if (BMI <= 18.5)
                Console.WriteLine("Your underweight");
            else
                if (BMI <= 25)
                Console.WriteLine("You have normal Weight");
            else
                if (BMI <= 30)
                Console.WriteLine("You're Overweight");
            else
                if (BMI <= 35)
                Console.WriteLine("You're moderately obese");
            else
                Console.WriteLine("Your severely obese");

        }
    }

















}
