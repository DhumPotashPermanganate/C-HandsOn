using BMICalculator.App02;

namespace BMICalculator;

/// <summary>
/// This class runs first and create a DistanceConverter
/// allowing the user three ways of converting distances
/// </summary>
/// <author>
/// Amir Azam
/// 22135972
/// </author>
public static class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine(" ================================================");
        Console.WriteLine("  BNU CO453 Applications Programming 2021-2022!");
        Console.WriteLine("        by Amir Azam (22135972)      ");
        Console.WriteLine(" ================================================");
        Console.WriteLine("");
        
        BMI bmi = new BMI();
        bmi.Start();
    }
}