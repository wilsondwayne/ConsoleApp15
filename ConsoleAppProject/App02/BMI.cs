using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Dwayne Wilson version 0.1
    /// </author>
    public class BMI
    {
        double weightImperial;
        double heightImperial;
        string unitChoice;
        public double HeightInFeet;
        public double HeightInInches;
        public double HeightInMetres;
        public double WeightInStones;
        public double WeightInPounds;
        public double WeightInKg;
        double imperialBMI;
        double metricBMI;

        /// <summary>
        /// This method is what will run features on the app.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            TypeOfUnit();
            EthnicMessage();
        }
        /// <summary>
        /// This method will will print the heading message
        /// when the application is run.
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("              Body Mass Index Calculator         ");
            Console.WriteLine("                   By Dwayne Wilson                 ");
            Console.WriteLine("-------------------------------------------------");
        }

        /// <summary>
        ///  This method will display a message allowing the user to choose their 
        /// unit of choice.It will ask for their weight height which they have chosen to measure in.
        /// </summary>
        public void TypeOfUnit()
        {
            Console.WriteLine(" 1. Metric Units ");
            Console.WriteLine(" 2. Imperial Units ");
            Console.Write(" \n Please enter your choice of unit > ");
            unitChoice = Console.ReadLine();

            if (unitChoice == "1")
            {
                Console.WriteLine(" \n Please enter your height to the nearest Metre and Kilogram ");
                Console.Write("\n Enter here your height in metres > ");
                string height = Console.ReadLine();
                HeightInMetres = Convert.ToDouble(height);
                Console.Write(" \n Enter your weight in KG > ");
                string kg = Console.ReadLine();
                WeightInKg = Convert.ToDouble(kg);
                Console.WriteLine();
                Console.WriteLine();
                MetricFormula();
                BMIConditions(metricBMI);
            }

            else if (unitChoice == "2")
            {
                Console.WriteLine("\n Please enter your height to the nearest foot and inch  ");
                Console.Write("\n Enter here your height in feet > ");
                string height = Console.ReadLine();
                HeightInFeet = Convert.ToDouble(height);


                Console.Write(" Enter here your height in inches > ");
                string inches = Console.ReadLine();
                HeightInInches = Convert.ToDouble(inches);

                Console.WriteLine("\n Enter your weight to the nearest stone and pound ");
                Console.Write("\n Enter here your weight in stones > ");
                string stones = Console.ReadLine();
                WeightInStones = Convert.ToDouble(stones);

                Console.Write(" Enter here your weight in pounds> ");
                string pounds = Console.ReadLine();
                WeightInPounds = Convert.ToDouble(pounds);

                ImperialFormula();
                BMIConditions(imperialBMI);
            }
        }

        /// <summary>
        /// This method is used to work out the BMI of the
        /// user if they chose to use the Imperial unit.
        /// </summary>
        public void ImperialFormula()
        {
            double Pounds = WeightInStones * 14;
            weightImperial = WeightInPounds + Pounds;

            double inches = HeightInFeet * 12;
            heightImperial = HeightInInches + inches;

            imperialBMI = weightImperial * 703 / (heightImperial * heightImperial);
        }

        /// <summary>
        /// This method is used to work out the BMI of the
        /// user if they chose to use the Metric unit.
        /// </summary>
        public void MetricFormula() => metricBMI = WeightInKg / (HeightInMetres * HeightInMetres);

        /// <summary>
        /// This method will print out the results for
        /// the user and will also tell them what category
        /// they are in.
        /// </summary>
        /// <param name="BMI"></param>
        public void BMIConditions(double BMI)
        {
            if (BMI < 18.5)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are undeweight");
            }

            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are Normal");
            }

            else if (BMI >= 25.0 && BMI <= 29.9)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are overweight");
            }

            else if (BMI >= 30.0 && BMI <= 34.9)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are in obese Class 1");
            }

            else if (BMI >= 35.0 && BMI <= 39.9)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are in Obese Class 2");
            }

            else if (BMI >= 40.0)
            {
                Console.WriteLine(" Your BMI is " + BMI);
                Console.WriteLine(" You are in Obese Class 3");
            }
        }

        /// <summary>
        /// This is an ethnic message that will print at the end
        /// of the test to give the user of additonal information they
        /// will need to know.If they are of an ethnic background they should take atcion.
        /// </summary>
        public void EthnicMessage()
        {
            Console.WriteLine(" If you are Black, Asian or minority \n ethnic groups, you have a risk");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine(" Adults 27.5 or more at high risk");
        }

    }
}
