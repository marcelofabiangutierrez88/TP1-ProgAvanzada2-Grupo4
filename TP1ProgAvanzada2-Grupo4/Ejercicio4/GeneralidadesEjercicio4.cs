using System;

public class GeneralidadesEjercicio4

{
    public static void Main()
    {
       cutString("avanzada");
    }

    public static void cutString(String a)
    {
        // Funcion que devuelve la cadena cortada que se pasa por parametro 
        String myString = a;
        Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4));

    }
}