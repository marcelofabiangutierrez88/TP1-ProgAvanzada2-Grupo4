using System;

public class GeneralidadesEjercicio1

{
    public static void Main()
    {
        int a = 4;
        int b = 1;
        int suma = sumar(a, b);
    }

    public static int sumar(int a, int b)
    {
        int suma = a + b;
        Console.WriteLine("La suma es: " + suma);
        return suma;
    }
}