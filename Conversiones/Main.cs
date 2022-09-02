using Conversiones;

public class Ejercicios
{
    public static void Main()
    {
        Console.WriteLine("Para ejecutar los puntos de los distintos temas: \n" +
            "1- Seleccionar con click derecho el proyecto que deseas ejecutar. \n" +
            "2- Seleccionar 'Establecer como proyecto de inicio'. \n \n");
        Console.WriteLine("----- Conversiones -----\n");
        Punto1 punto1 = new Punto1();
        Punto2 punto2 = new Punto2();
        Punto3 punto3 = new Punto3();
        Punto4 punto4 = new Punto4();
        Punto5 punto5 = new Punto5();
        Punto6 punto6 = new Punto6();
        Punto7 punto7 = new Punto7();

        punto1.RtaPunto1();
        punto2.rtaPunto2();
        punto3.rtaPunto3("blanco");
        punto4.rtaPunto4();
        punto5.rtaPunto5();
        punto6.rtaPunto6();
        punto7.rtaPunto7();
    }
}
