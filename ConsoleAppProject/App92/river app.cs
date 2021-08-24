using System;
namespace ConsoleAppProject.App92
{
    public class RiverApp
    {
        public void Run()
        {
            InputChessRiverData();
            InputColneRiverData();
            InputGadeRiversData();

        }
        public void InputChessRiverData()
        {
            Console.WriteLine("THIS IS THE RIVER CHESS DATA ");
            double[] WeeklyTemp = new double[7];
            double[] WeeklyOxygen = new double[7];
            double[] WeeklyWaterLevel = new double[7];
            string[] days = {"Monday", "Tuesday", "Wednesday","Thursday",
             "Friday","Saturday","Sunday"};

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"Enter data for {days[i]}");

                Console.WriteLine($"Enter temp data for {days[i]}");
                WeeklyTemp[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter Oxygen levels for {days[i]}");
                WeeklyOxygen[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter height of water for {days[i]}");
                WeeklyWaterLevel[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{days[i]}\n Temp (°C): {WeeklyTemp[i]}\n " +
                $"Oxygen (Mg/l) {WeeklyOxygen[i]}\n " +
                $"Water Levels " + $"Height(metres) {WeeklyWaterLevel[i]}");
            }
        }

        public void InputGadeRiversData()
        {
            Console.WriteLine("THIS IS THE RIVER GADE DATA");
            InputChessRiverData();
        }

        public void InputColneRiverData()
        {
            Console.WriteLine("THIS IS THE RIVER COLNE DATA");
            InputChessRiverData();
        }
    }

}