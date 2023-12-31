﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsReportCard_OOPAndFilling_
{
    public class Sort
    {
        private Student[] Students;

        public Sort(Student[] Students)
        {
            this.Students = Students;
        }

        public void SortByWritten()
        {
            double Average = 0;
            string Name = "";
            Console.Write("Please enter the number of students that you want to sort: ");
            string Input = Console.ReadLine();
            Student Student = new Student("");

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Length)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        for (int j = 0; j < Students.Length; j++)
                        {
                            if (Students[j].AverageWritten() > Average)
                            {
                                Average = Students[j].AverageWritten();
                                Name = Students[j].Name;
                                Student = Students[j];
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name.Replace(" ", "")},  Average: {Average}");
                        int Index = Array.IndexOf(Students, Student);
                        for (int x = Index + 1; x < Students.Length; x++)
                        {
                            Students[x - 1] = Students[x];

                        }
                        Students[Students.Length - 1] = new Student("");

                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("Please enter a correct number!!!");
            }
            else
                Console.WriteLine("Please enter a correct number!!!");
        }

        public void SortByPractical()
        {
            double Average = 0;
            string Name = "";
            Console.Write("Please enter the number of students that you want to sort: ");
            string Input = Console.ReadLine();
            Student Student = new Student("");

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Length)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        for (int j = 0; j < Students.Length; j++)
                        {
                            if (Students[j].AveragePractical() > Average)
                            {
                                Average = Students[j].AveragePractical();
                                Name = Students[j].Name;
                                Student = Students[j];
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name.Replace(" ", "")},  Average: {Average}");
                        int Index = Array.IndexOf(Students, Student);
                        for (int x = Index + 1; x < Students.Length; x++)
                        {
                            Students[x - 1] = Students[x];

                        }
                        Students[Students.Length - 1] = new Student("");

                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("Please enter a correct number!!!");
            }
            else
                Console.WriteLine("Please enter a correct number!!!");
        }

        public void SortByTheorical()
        {
            double Average = 0;
            string Name = "";
            Console.Write("Please enter the number of students that you want to sort: ");
            string Input = Console.ReadLine();
            Student Student = new Student("");

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Length)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        for (int j = 0; j < Students.Length; j++)
                        {
                            if (Students[j].AverageTheorical() > Average)
                            {
                                Average = Students[j].AverageTheorical();
                                Name = Students[j].Name;
                                Student = Students[j];
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name.Replace(" ", "")},  Average: {Average}");
                        int Index = Array.IndexOf(Students, Student);
                        for (int x = Index + 1; x < Students.Length; x++)
                        {
                            Students[x - 1] = Students[x];

                        }
                        Students[Students.Length - 1] = new Student("");

                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("Please enter a correct number!!!");
            }
            else
                Console.WriteLine("Please enter a correct number!!!");
        }

        public void SortByMain()
        {
            double Average = 0;
            string Name = "";
            Console.Write("Please enter the number of students that you want to sort: ");
            string Input = Console.ReadLine();
            Student Student = new Student("");

            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= Students.Length)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        for (int j = 0; j < Students.Length; j++)
                        {
                            if (Students[j].AverageMain() > Average)
                            {
                                Average = Students[j].AverageMain();
                                Name = Students[j].Name;
                                Student = Students[j];
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name.Replace(" ", "")},  Average: {Average}");
                        int Index = Array.IndexOf(Students, Student);
                        for (int x = Index + 1; x < Students.Length; x++)
                        {
                            Students[x - 1] = Students[x];

                        }
                        Students[Students.Length - 1] = new Student("");

                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("Please enter a correct number!!!");
            }
            else
                Console.WriteLine("Please enter a correct number!!!");
        }

        public void SortByGrade()
        {
            double Average = 0;
            string Name = "";
            char Grade = ' ';
            Student Student = new Student("");
            Console.Write("Please enter the number of students that you want to sort: ");
            string Input = Console.ReadLine();


            if (IsNotNull(Input) && IsInt(Input))
            {
                int Number = Convert.ToInt32(Input);
                if (Number <= 100)
                {
                    for (int i = 0; i < Number; i++)
                    {
                        for (int j = 0; j < Students.Length; j++)
                        {

                            if (Students[j].AverageGeneral() > Average)
                            {
                                Average = Students[j].AverageGeneral();
                                Name = Students[j].Name;
                                Grade = Students[j].Rank(Students[j].AverageGeneral());
                                Student = Students[j];
                            }
                        }
                        Console.WriteLine($"{i + 1}.Name:{Name.Replace(" ", "")},  Average: {Average},  Grade: {Grade}");
                        int Index = Array.IndexOf(Students, Student);
                        for (int x = Index + 1; x < Students.Length; x++)
                        {
                            Students[x - 1] = Students[x];

                        }
                        Students[Students.Length - 1] = new Student("");

                        Average = 0;
                    }
                }
                else
                    Console.WriteLine("Please enter a correct number!!!");
            }
            else
                Console.WriteLine("Please enter a correct number!!!");
        }

        private bool IsInt(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNotNull(string Input)
        {
            if (Input.Replace(" ", "") == "")
                return false;
            return true;
        }
    }
}
