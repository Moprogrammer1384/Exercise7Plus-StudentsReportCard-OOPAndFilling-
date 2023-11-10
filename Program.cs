//***********************************
// Student Name : Mohammad Ali Amirkhani
// Lesson Name : Advanced Programming (1)
// Practice Number : 7(OOPAndFilling)
//***********************************

using StudentsReportCard_OOPAndFilling_;
using System.IO;

Student[] Students = new Student[100];
Sort Sort;
string path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", "Names.txt");
string[] StudentsNames = System.IO.File.ReadAllLines(path);



void GenerateStudent()
{
    for (int i = 0; i < Students.Length; i++)
    {
        Student Student = new Student(StudentsNames[i]);
        Students[i] = Student;

    }
}

void Welcome()
{
    Console.WriteLine("*****************************************");
    string Menu = @"Welcome to student manager program:
1.Written Average
2.Practical Average
3.Theorical Average
4.Main Average
5.General Average
6.Top students by written average
7.Top students by practical average
8.Top students by theorical average
9.Top students by main average 
10.Top students by grade
11.Find prime numbers in lessons marks
12.Exit";
    Console.WriteLine(Menu);
    Console.WriteLine("*****************************************");

}

void SelectOption()
{
    do
    {
        Welcome();
        Console.Write("Please choose one of the options: ");
        GenerateStudent();
        Sort = new Sort(Students);
        switch (Console.ReadLine())
        {
            case "1":
                PrintAverage("WrittenAverage");
                break;
            case "2":
                PrintAverage("PracticalAverage");
                break;
            case "3":
                PrintAverage("TheoricalAverage");
                break;
            case "4":
                PrintAverage("MainAverage");
                break;
            case "5":
                PrintAverage("GeneralAverage");
                break;
            case "6":
                Sort.SortByWritten();
                break;
            case "7":
                Sort.SortByPractical();
                break;
            case "8":
                Sort.SortByTheorical();
                break;
            case "9":
                Sort.SortByMain();
                break;
            case "10":
                Sort.SortByGrade();
                break;
            case "11":
                ShowPrimeNumbers();
                break;
            case "12":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Please enter a correct number!!!!!");
                break;

        }
    } while (true);
}

void PrintAverage(string Type)
{
    Console.WriteLine($"***{Type}s***");
    for (int i = 0; i < Students.Length; i++)
    {
        switch (Type)
        {
            case "WrittenAverage":
                Console.WriteLine($"{Students[i].Name} : {Students[i].AverageWritten()}");
                break;
            case "PracticalAverage":
                Console.WriteLine($"{Students[i].Name} : {Students[i].AveragePractical()}");
                break;
            case "TheoricalAverage":
                Console.WriteLine($"{Students[i].Name} : {Students[i].AverageTheorical()}");
                break;
            case "MainAverage":
                Console.WriteLine($"{Students[i].Name} : {Students[i].AverageMain()}");
                break;
            case "GeneralAverage":
                Console.WriteLine($"{Students[i].Name} : {Students[i].AverageGeneral()}");
                break;
        }
    }
}

void ShowPrimeNumbers()
{
    Console.WriteLine("***Prime numbers for all student***");
    for (int i = 0; i < Students.Length; i++)
    {
        Students[i].PrimeNumbers();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("--------------------------------------");
    }
}

SelectOption();



