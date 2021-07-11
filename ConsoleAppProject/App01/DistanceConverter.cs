using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The app will prompt the user to input a distance
    /// in one unit (fromUnit) and will calculate
    /// and output the distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Dwayne Wilson version 0.3
    /// </author>
    
    public class DistanceConverter 
    {
        public const int feet_in_miles = 5280;

        private double miles;

        private double feet;


        /// <summary>
        /// this is the line of code that get called up from the program class
        /// </summary>
        public void Run() 
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading() 
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n      DISTANCE CONVERTER      ");
            Console.WriteLine("\n        By Dwayne Wilson         ");
            Console.WriteLine("\n------------------------------");

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
        /// 
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


