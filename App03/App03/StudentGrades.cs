using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public int MenuChoice;
        public int size;

        public Tuple<String, double, Grades>[] StudentData;
        /*public static void Main(string[] args)
        {
            Start();
            //Input();
        }*/

        public void Start()
        {
            string[] menu =
            {
                "Input Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile",
                "Quit"
            };
            
            MenuChoice = Utilities.SelectChoice(menu);
            choiceRouter(MenuChoice);
        }

        public void choiceRouter(int MenuChoice)
        {
            switch (MenuChoice)
            {
                case 1: Input();
                    break;
                case 2: OutputMarks();
                    break;
                case 3: OutputStats();
                    break;
                case 4: OutputGradeProfile();
                    break;
                case 5: Quit();
                    break;
                default: Console.WriteLine("Wrong Option Entered! ");
                    break;
            }
                
        }

        public void Input()
        {
            Console.WriteLine("Enter the numbers of students: ");
            size = Convert.ToInt32(Console.ReadLine());
            StudentData = new Tuple<string, double, Grades>[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter name: ");
                String name = Console.ReadLine();
                double marks = Utilities.Input("Enter Marks: ");
                StudentData[i] = Tuple.Create(name, marks, CalculateGrade(marks));
            }
            OutputMarks();
        }

        public Grades CalculateGrade(double marks)
        {
            Grades grade= Grades.F;
            if (marks >= 70 && marks <= 100)
                grade = Grades.A;
            else if(marks >=60 && marks<=69)
                grade =Grades.B;
            else if(marks >=50 && marks<=59)
                grade = Grades.C;
            else if(marks >=40 && marks<=49)
                grade = Grades.D;
            else 
                grade = Grades.F;

            return grade;
        }
        
        

        public void OutputMarks()
        {
            Console.WriteLine("Name\t\tMarks\t\tGrade\t\tClassification");
            foreach (var i in StudentData)
            {
                Console.WriteLine(i.Item1+ "\t\t" +i.Item2+"\t\t" + i.Item3 + "\t\t" + i.Item3.GetEnumDescription());
            }
        }

        public void OutputStats()
        {
            
        }

        public void OutputGradeProfile()
        {
            
        }

        public void Quit()
        {
            
        }
    }
}