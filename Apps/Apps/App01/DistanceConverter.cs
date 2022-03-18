using System;
using System.Threading;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Amir Azam
    /// 22135972
    /// </author>
    public class DistanceConverter
    {

        Tuple<int, int, double, string, string>[] conversion =
        {
            Tuple.Create(1 , 2 , 1609.344 , "Miles", "Metres"),
            Tuple.Create(1 , 3 , 1760.0 , "Miles", "Yard"),
            Tuple.Create(1 , 4 , 5280.0 , "Miles", "Feet"),
            Tuple.Create(1 , 5 , 160934.0 , "Miles" , "Centimeter"),
            Tuple.Create(1 , 6 , 1609340.0, "Miles" , "Millimeter"),
            Tuple.Create(2 , 3 , 1.09361 , "Metres", "Yard"),
            Tuple.Create(2 , 4 , 3.28084 , "Metres", "Feet"),
            Tuple.Create(2 , 5 , 100.0 , "Metres", "Centimeter"),
            Tuple.Create(2 , 6 , 1000.0 , "Metres" , "Millimeter"),
            Tuple.Create(3 , 4 , 3.0 , "Yard", "Feet"),
            Tuple.Create(3 , 5 , 91.44 , "Yard" , "Centimeter"),
            Tuple.Create(3 , 6 , 914.4, "Yard" , "Millimeter"),
            Tuple.Create(4 , 5 , 30.48 , "Feet" , "Centimeter"),
            Tuple.Create(4 , 6, 304.8 , "Feet" , "Millimeters"),
            Tuple.Create(5 , 6 , 10.0, "Centimeter", "Millimetres")
        };
        
        public double inputParam = 0;
        public double outputParam = 0;
        private int choice1;
        private int choice2;
        private string first= "";
        private string second = "";
        private bool flag = true;
        
        
        public void Run()
        {
            Start();
            Calculate(choice1, choice2);
            Output(outputParam, first, second);
        }

        private void Start()
        {
            Console.WriteLine("Please Select your from unit");
            
            
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Yard");
            Console.WriteLine("4. Feet");
            Console.WriteLine("5. Centimeter");
            Console.WriteLine("6. Millimeter");
            
            Console.Write("Please Enter your Choice > ");
            choice1 = Convert.ToInt32(Console.ReadLine());
            while (!(choice1 >= 1 && choice1 <=6))
            {
                Console.WriteLine("Enter a choice between 1 and 6...");
                Console.Write("Please Enter your Choice1 > ");
                choice1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please Select your to unit");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Yard");
            Console.WriteLine("4. Feet");
            Console.WriteLine("5. Centimeter");
            Console.WriteLine("6. Millimeter");
            Console.Write("Please Enter your Choice > ");
            choice2 = Convert.ToInt32(Console.ReadLine());
            while (!(choice2 >= 1 && choice2 <=6))
            {
                Console.WriteLine("Enter a choice between 1 and 6...");
                Console.Write("Please Enter your Choice2 > ");
                choice2 = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        
        private void Input(string from)
        {
            try
            {
                Console.Write("Enter the distance in " + from + " : ");
                inputParam = Convert.ToDouble(Console.ReadLine());
                while (inputParam < 0)
                {
                    Console.WriteLine("Invalid Input!\nEnter a value greater than 0...");
                    Console.Write("Enter the distance in " + from + " : ");
                    inputParam = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Input");
                Input(from);
            }
        }

        public void Calculate(int choice1, int choice2)
        {
            foreach (var i in conversion)
            {
                
                if (i.Item1 == choice1 && i.Item2 == choice2)
                {
                    Console.WriteLine("\nYou are converting from "+i.Item4+" to "+i.Item5+"!");
                    Input(i.Item4);
                    first = i.Item4;
                    second = i.Item5;
                    outputParam = inputParam * i.Item3;
                }
                else if (i.Item1 == choice2 && i.Item2 == choice1)
                {
                    Console.WriteLine("\nYou are converting from "+i.Item5+" to "+i.Item4+"!");
                    Input(i.Item5);
                    first = i.Item5;
                    second = i.Item4;
                    outputParam = inputParam / i.Item3;
                }
                else if (choice1 == choice2)
                {
                    flag = false;
                }
            }
        }

        private void Output(double outputParam, string first, string second)
        {
            if (flag)
                Console.WriteLine("\n"+inputParam+ " " +first+ " = "+ outputParam+ " " +second);
            else
                Console.WriteLine("Your To and From Units of Conversion are same. Please Enter Different Units...");
            
        }
        
    }
}
