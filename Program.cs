using System;

public class MainClass
{
    public static void Main()
    {
        double y;
            Console.WriteLine("Введите значение a");
            var a=Convert.ToDouble(Console.ReadLine());
        y = (Math.Pow(a,2)+10)/(Math.Sqrt(Math.Pow(a, 2) + 1));
        Console.WriteLine(y);
        Console.ReadKey();
    }
    
}