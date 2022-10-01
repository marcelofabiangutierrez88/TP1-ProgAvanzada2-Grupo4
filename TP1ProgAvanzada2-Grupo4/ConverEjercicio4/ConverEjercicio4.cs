using System;
public class ConverEjercicio4
{
    public static void Main()
    {
        int a = 11;
        validateNumber(a);  
    }

    public static int validateNumber(int number)
    {
        if (number > 10)
        {
            Console.WriteLine("Es mayor que 10");
            return number;
        }
        return number;
    }
}