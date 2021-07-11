using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
<<<<<<< HEAD
    /// The app will prompt the user to input a distance
=======
    /// The app wll prompt the user to input a distance
>>>>>>> 83cb233aa7eb8b9c8a4f72f7656a83ffcb859fd7
    /// in one unit (fromUnit) and will calculate
    /// and output the distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Dwayne Wilson version 0.3
    /// </author>
    
    public class DistanceConverter 
    {
<<<<<<< HEAD
        public const int feet_in_miles = 5280;
=======
        /// <summary>
        /// Conversions constants
        /// </summary>
        /// 
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.280884;
>>>>>>> 83cb233aa7eb8b9c8a4f72f7656a83ffcb859fd7

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





<<<<<<< HEAD




=======
        /// <summary>
        /// This is a short descripton of the programme and the author of it
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n      DISTANCE CONVERTER      ");
            Console.WriteLine("\n        By Dwayne Wilson         ");
            Console.WriteLine("\n------------------------------");
        }
        
>>>>>>> 83cb233aa7eb8b9c8a4f72f7656a83ffcb859fd7

    }
   
}


