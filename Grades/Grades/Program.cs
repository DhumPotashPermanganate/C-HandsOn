namespace App03;
class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine();
        Console.WriteLine(" =================================================");
        Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
        Console.WriteLine("                     Amir Azam                              \n " +
                          "                      22135972 ");
        Console.WriteLine(" =================================================");
        Console.WriteLine();
        Grades obj = new Grades();
        obj.Run();
    }
}