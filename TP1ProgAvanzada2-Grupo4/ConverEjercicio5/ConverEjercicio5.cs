using System;
public class ConverEjercicio5
{
    public static void Main()
    {
        int a = 9;
        validateNumberGreaterThanTen(a);
    }
    public static int validateNumberGreaterThanTen(int number)
    {
        if (number > 10)
        {
            Console.WriteLine("Es mayor que 10");
        }
        else
        {
            Console.WriteLine("No es mayor que 10");
        }
        return number;
    }
}