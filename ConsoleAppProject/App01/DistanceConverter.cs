using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The app will prompt the user to input a distance
    /// The app wll prompt the user to input a distance
    /// in one unit (fromUnit) and will calculate
    /// and output the distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Dwayne Wilson version 0.3
    /// </author>
    
    public class DistanceConverter 
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.280884;


        /// <summary>
        /// Conversions constants
        /// </summary>
        /// 
       
        private double miles;

        private double feet;


        /// <summary>
        /// this is the line of code that get called up from the program class
        /// </summary>
        public void Run() 
        {
            OutputHeading("Distance converter");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

         /// <summary>
        /// this method will input the distance measured in miles calculate 
        /// the same distance in feet and output the distance in feet.
        /// </summary>
        public void MilesToFeet() 
        {
            OutputHeading("Converting Miles to Feet");
            miles = InputDistance("enter the number of miles > ");
            CalculateFeet();
            OutputFeet();
        }

         /// <summary>
        /// this method will input the distance measured in feet calculate 
        /// the same distance in miles and output the distance in feet.
        /// </summary>
        public void FeetToMiles() 
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("enter the number of feet > ");
            CalculateFeet();
            OutputFeet();
        }

         /// <summary>
        /// this method will input the distance measured in miles calculate 
        /// the same distance in meters and output the distance in feet.
        /// </summary>
        public void MilesToMeters() 
        {
            OutputHeading("Converting Miles to Meters");
            miles = InputDistance("enter the number of miles > ");
            CalculateFeet();
            OutputFeet();
        }



        /// <summary>
        /// This is a short descripton of the programme and the author of it
        /// </summary>
        private void OutputHeading(String prompt) 
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n      DISTANCE CONVERTER      ");
            Console.WriteLine("\n        By Dwayne Wilson         ");
            Console.WriteLine("\n------------------------------");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

        /// <summary>
        /// tell the user to enter the selcted value.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private double InputDistance(string prompt) 
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }



        /// <summary>
        /// Tells the user to enter the distance in miles
        /// </summary>

        private void InputMiles()
        {
            Console.Write("Enter the amount of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        /// <summary>
        /// This method calcluates the distances
        /// depending on what the user has choose.
        /// </summary>

        private void CalculateFeet()
        {
            feet = miles * 5280;

        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet() 
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }



    }
   
}


