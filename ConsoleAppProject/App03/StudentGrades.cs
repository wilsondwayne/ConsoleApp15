using System;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public string[] Students;
        public int[] Grades;

        public const int FIRSTCLASS = 70;
        public const int UPPERSECONDCLASS = 60;
        public const int LOWERSECONDCLASS = 50;
        public const int THIRDCLASS = 40;
        public const int FAIL = 0;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("Student Grades");

            InputMarks();
            DisplayStudentData();
            CalculateMinMaxAndMean();
        }

        public void InputMarks()
        {
            int mark = 0;

            Grades = new int[10];
            Students = new string[]
            {
                "Dwayne Wilson", "Yami Kuga", "Pete Smith", "Mason Banner",
                "Maya Hansen", "Klay Thompson", "Gabi Sean", "Natasha Shelvey",
                "Harold Churchill", "Gordon Naismith"
            };

            for (int i = 0; i < Students.Length; i++)
            {
                mark = (int)ConsoleHelper.InputNumber(
                    " Please enter the marks achieved by " + Students[i] + " Here > ", 0, 100);

                Grades[i] = mark;
            }

            Console.WriteLine("\nAll the Student Grades have been added to the system \n");
        }

        public Grades CalculateGrade(int Marks)
        {
            if (Marks >= FAIL && Marks < THIRDCLASS)
            {
                return App03.Grades.F;
            }
            else if (Marks >= THIRDCLASS && Marks < LOWERSECONDCLASS)
            {
                return App03.Grades.D;
            }
            else if (Marks >= LOWERSECONDCLASS && Marks < UPPERSECONDCLASS)
            {
                return App03.Grades.C;
            }
            else if (Marks >= UPPERSECONDCLASS && Marks < FIRSTCLASS)
            {
                return App03.Grades.B;
            }
            else
            {
                return App03.Grades.A;
            }
        }

        public void DisplayStudentData()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("Student name : " + Students[i] +
                    "\nStudent Mark " + Grades[i] + "\nGrade: " + CalculateGrade(Grades[i]) + "\n");
            }
        }

        public void CalculateMinMaxAndMean()
        {
            int min = Grades[0];
            int max = Grades[0];

            double numCount = 0;
            double mean = 0;

            for (int i = 0; i < Grades.Length; i++)
            {
                if (min > Grades[i])
                {
                    min = Grades[i];
                }

                if (max < Grades[i])
                {
                    max = Grades[i];
                }

                mean += Grades[i];
                numCount++;
            }
            Console.WriteLine("The minimum mark achieved by a student was: " + min +
                "\nThe maximum mark achieved by a student was: " + max + "\nThe mean of all marks was: " + (mean / numCount));
        }

    }
}