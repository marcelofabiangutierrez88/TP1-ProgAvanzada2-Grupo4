using Enumeraciones;

public class Ejercicios
{
    public static void Main()
    {
        Console.WriteLine("Para ejecutar los puntos de los distintos temas: \n" +
            "1- Seleccionar con click derecho el proyecto que deseas ejecutar. \n" +
            "2- Seleccionar 'Establecer como proyecto de inicio'. \n \n");
        Console.WriteLine("----- Enumeraciones -----\n");

        Punto1 punto1 = new Punto1();
        Punto2 punto2 = new Punto2();

        punto1.rtaPunto1();
        punto2.rtaPunto2();
    }
}