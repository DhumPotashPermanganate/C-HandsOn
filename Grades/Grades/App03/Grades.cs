using System.Linq;

namespace App03;

public class Grades
{
    public int size;
    public string[] StudentName;
    public double[] StudentMark;
    public string[] StudentGrade;

    public double mean = 0.0;
    public double highest = 0.0;
    public double lowest = 0.0;

    public string highestName = "";
    public string lowestName = "";
    
    public string[] grades =
    {
        "A Bsc(Hons) First Class",
        "B Bsc(Hons) Upper Class",
        "C Bsc(Hons) Lower Second",
        "D Bsc(Hons) Third Class",
        "F Referred"
    };
    public void Run()
    {
        
        char continueVariable = 'Y';

        do
        {
            heading("MENU");
            Console.WriteLine("1.Input Marks\n"+
                "2.Output Marks\n"+
                "3.Output Stats\n"+
                "4.Output Grade Profile\n"+
                "5.Quit\n");
            Console.Write("\n\nEnter your choice >>> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Input(); break;
                case 2: PrintMarks(); break;
                case 3: PrintStatistics(); break;
                case 4: PrintGradeProfile(); break;
                case 5: Console.WriteLine("THANK YOU!");continueVariable = 'N'; break;
                default: Console.WriteLine("Wrong Option Entered! "); break;
            }
        } while (continueVariable == 'Y');
    }


    public string AssignGrade(double marks)
    {
        string grade = "";
        if (marks >= 70 && marks <= 100)
            grade = "A Bsc(Hons) First Class";
        else if(marks >=60 && marks<=69)
            grade = "B Bsc(Hons) Upper Class";
        else if(marks >=50 && marks<=59)
            grade = "C Bsc(Hons) Lower Second";
        else if(marks >=40 && marks<=49)
            grade = "D Bsc(Hons) Third Class";
        else 
            grade = "F Referred";
        return grade;
    }
    
    public void Input()
    {
        Console.Write("Numbers of students >>> ");
        size= Convert.ToInt32(Console.ReadLine());

        StudentName = new string[size];
        StudentMark = new double[size];
        StudentGrade = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter Name >>> ");
            StudentName[i] = Console.ReadLine();
            Console.Write("Enter Marks >>> ");
            StudentMark[i] = Convert.ToDouble(Console.ReadLine());
            StudentGrade[i] = AssignGrade(StudentMark[i]);
        }
        
    }

    public void PrintMarks()
    {
        heading("Marks of Students");
        Console.WriteLine("Name\tMarks\tGrade\tClassification");
        Console.WriteLine("----\t-----\t-----\t--------------");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{StudentName[i]}\t" +
                              $"{StudentMark[i]}\t" +
                              $"{StudentGrade[i].Substring(0, 1)}\t" +
                              $"{StudentGrade[i].Substring(1, StudentGrade[i].Length-1)}");
        }
        
    }

    public void PrintStatistics()
    {
        heading("Statistics of Performance");
        mean = StudentMark.Average();
        highest = StudentMark.Max();
        lowest = StudentMark.Min();
        highestName = StudentName[Array.IndexOf(StudentMark, highest)];
        lowestName = StudentName[Array.IndexOf(StudentMark, lowest)];
        Console.WriteLine($"\t\tMean: {mean}\n" +
                          $"Highest Marks: {highest} \t Student: {highestName}\n" +
                          $"Lowest Marks: {lowest} \t Student: {lowestName}\n");
    }

    public void PrintGradeProfile()
    {
        heading("Grade Profile");
        Console.WriteLine($"Grade A: {StudentGrade.Count(s=> s=="A Bsc(Hons) First Class")}");
        Console.WriteLine($"Grade B: {StudentGrade.Count(s=> s=="B Bsc(Hons) Upper Class")}");
        Console.WriteLine($"Grade C: {StudentGrade.Count(s=> s=="C Bsc(Hons) Lower Second")}");
        Console.WriteLine($"Grade D: {StudentGrade.Count(s=> s=="D Bsc(Hons) Third Class")}");
        Console.WriteLine($"Grade F: {StudentGrade.Count(s=> s=="F Referred")}");
    }

    public void heading(string head)
    {
        Console.WriteLine("\n****************************************************");
        Console.WriteLine($"\t\t{head}");
        Console.WriteLine("****************************************************");
    }
    
}