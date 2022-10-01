using System;

public class GeneralidadesEjercicio2

{
    public static void Main()
    {
        Console.WriteLine("Cadena Cortada " + cutString("avanzada"));
        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }

    public static String cutString(String a)
    {
        return a.Remove(4, 4);
    }
}