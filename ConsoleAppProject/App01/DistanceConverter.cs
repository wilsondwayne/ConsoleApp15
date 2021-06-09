using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The app iwll prompt the user to input a distance
    /// in one unit (fromUnit) and will calculate
    /// and output the distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Dwayne Wilson version 0.3
    /// </author>

    public class DistanceConverter
    {
        /// <summary>
        /// Conversions constants
        /// </summary>
        /// 
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;


        public const double FEET_IN_METRES = 3.280884;

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
        /// The purpose of this method is to call the other methods
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from unit distance unit >");
            toUnit = SelectUnit(" Please select the to distance unit >");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} >");

            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// This method calcluates the distances
        /// depending on what they user chooses.
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
        }



        /// <summary>
        /// This method will return this message confirming
        /// with the user the unit they have chosen.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;

        }
        /// <summary>
        /// This method is for when the user has chosen their unit
        /// and this method will recognise their choice.
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return MILES;
            }
            else if (choice.Equals("3"))
            {
                return METRES;
            }
            return null;
        }

        /// <summary>
        /// This method will display the user choices.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {MILES}");
            Console.WriteLine($" 3. {METRES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompts the user to enter the miles.
        /// Input miles as double number
        /// </summary>
        ///

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This method is responsible for the output of the results
        /// after it has been calculated.
        /// It will print out the results at the end
        /// </summary>
        ///

        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit}" +
                        $" is {toDistance} {toUnit}!\n");
        }

        /// <summary>
        /// This is a short descriptoon of the programme and the author of it
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n      DISTANCE CONVERTER      ");
            Console.WriteLine("\n        By Dwayne Wilson         ");
            Console.WriteLine("\n------------------------------");
        }
        

    }
}

