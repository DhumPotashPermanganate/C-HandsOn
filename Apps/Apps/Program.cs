

using ConsoleAppProject.App01;

namespace apps;

/// <summary>
/// The main method in this class is called first
/// when the application is started.  It will be used
/// to start App01 
/// 
/// This Project has been modified by:
/// Amiz Azam
/// 22135972
/// </summary>


class program
{
    public static void Main(string[] args)
    {
        
        
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine();
        Console.WriteLine(" =================================================");
        Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
        Console.WriteLine("                 by Amir Azam 22135972            ");
        Console.WriteLine(" =================================================");
        Console.WriteLine();

        string[] app = {"Unit Converter", "BMI Calculator"};
        int exitnum = 1;
        do
        {
            Console.WriteLine(" =================================================");
            Console.WriteLine("            Hello, we have two apps");
            Console.WriteLine(" =================================================");
            int choice = Utilities.SelectChoice(app);

            if (choice == 1)
            {
                DistanceConverter dc = new DistanceConverter();
                dc.Run();
            }
            else
            {
                BMI bmi = new BMI();
                bmi.Start();
            }
            Console.WriteLine("\n=========================================================");
            Console.WriteLine("Press 1 to go back to main menu, Press 0 to exit >>> ");
            exitnum = Convert.ToInt32(Console.ReadLine());
        } while (exitnum != 0);
    }
}