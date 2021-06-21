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
    /// dwayne wilson Version 0.1
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This method will print the heading title.
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

            string[] choices = {" Distance Converter", " BMI Calculator", " Student Grades",
            " Social Network", " RPG Game"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConvertDistance();
            }
            else if (choice == 2)
            {


                App02.BMI calculator = new App02.BMI();
                calculator.Run();
            }
            else if (choice == 3)
            {
                StudentGrades grader = new StudentGrades();
                grader.Run();
            }
            else if (choice == 4)
            {
                SocialNetwork social = new SocialNetwork();
                social.Run();
            }

        }
    }
}