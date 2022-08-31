using System;

public class Ejercicio2
{
    public static void Main()
    {
        Console.WriteLine("Cadena Cortada " + cutString("avanzada"));
        Console.WriteLine("Press enter to close..."); 
        Console.ReadLine();
    }

    public static string cutString(string a)
    {
        return a.Remove(4,4);
    }
}

