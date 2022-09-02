using Generalidades;

public class Ejercicios
{
    public static void Main()
    {
        Console.WriteLine("Para ejecutar los puntos de los distintos temas: \n" +
            "1- Seleccionar con click derecho el proyecto que deseas ejecutar. \n" +
            "2- Seleccionar 'Establecer como proyecto de inicio'. \n \n");
        Console.WriteLine("----- Generalidades -----\n");
        
        Punto1 punto1 = new Punto1();
        Punto2 punto2 = new Punto2();
        Punto3 punto3 = new Punto3();
        Punto4 punto4 = new Punto4();
        Punto5 punto5 = new Punto5();

        punto1.rtaPunto1(4, 1);
        punto2.rtaPunto2("avanzada");
        punto3.rtaPunto3();
        punto4.rtaPunto4();
        punto5.rtaPunto5();
    }
}