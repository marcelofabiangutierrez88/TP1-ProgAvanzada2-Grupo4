using System;
public class ConverEjercicio7
{
    public static void Main()
    {
        int numero = 0;
        CycleNumber(numero);    
    }

    public static int CycleNumber(int number)
    {
        while (number < 50)
        {
            number += 5;
            Console.WriteLine(number);
        }
        return number;
    }
}