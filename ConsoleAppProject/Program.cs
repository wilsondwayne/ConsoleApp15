using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// This Project has been modified by:
    /// Dwayne Wilson Version 0.1
    public static class Program
    {
        /// <summary>
        /// This method will sho the heading title.
        /// conrol the color of the text.
        /// And run both distance converter and BMI application.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            DistanceConverter  converter = new DistanceConverter();
            converter.Run();

            converter.FeetToMiles();
            converter.MilesToMeters();
            converter.MilesToFeet();
           

        }
    }
}