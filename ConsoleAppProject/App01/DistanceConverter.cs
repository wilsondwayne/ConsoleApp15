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


        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }


        

        /// <summary>
        /// this method will input the distance measured in miles calculate 
        /// the same distance in feet and output the distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading($" Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($"enter the number of {fromUnit} > ");
            //CalculateFeet();
            OutputDistance(fromDistance, fromUnit, toDistance, toUnit);
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
           // miles = Convert.ToDouble(value);

        }

    

        ///<summary>
        ///
        ///</summary>
        private void OutputDistance(
            double fromDistance, string fromUnit, double toDistance, string toUnit)
        {
        Console.WriteLine($" {fromDistance}   {fromUnit}" + $" is {toDistance} {toUnit}!" ); 
        }

        /// <summary>
        /// 
        /// </summary>




    }
   
}


