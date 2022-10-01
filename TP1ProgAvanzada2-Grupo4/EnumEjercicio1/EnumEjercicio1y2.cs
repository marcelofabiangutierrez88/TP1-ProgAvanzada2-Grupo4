using System;

public class EnumEjercicio1y2
{
    public static void Main()
    {
        dias lunesUno = dias.Lunes;
        int lunes = (int)dias.Lunes;
        Console.WriteLine("Hoy es " + lunesUno + ", es el dia " + lunes + " de la semana");
    }
    public enum dias
    {
        Domingo = 1,
        Lunes = 2,
        Martes = 3,
        Miercoles = 4,
        Jueves = 5,
        Viernes = 6,
        Sabado = 7
    }




}