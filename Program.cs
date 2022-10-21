using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

public class Program

{
    public static void Main()

    {

        int a = 4;

        int b = 1;

        int suma = sumar(a, b);

        cutString("avanzada");

        Console.WriteLine(Now());

        dias lunesUno = dias.Lunes;

        int lunes = (int)dias.Lunes;

        Console.WriteLine("Hoy es " + lunesUno + ", es el dia " + lunes + " de la semana");

        //Conversiones 
        //1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados. 


        //3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.
        {
            String color = "blanco";

            switch (color)
            {
                case "blanco":
                    Console.WriteLine("El color es blanco");
                    break;
                case "azul":
                    Console.WriteLine("El color es azul");
                    break;
                case "negro":
                    Console.WriteLine("El color es negro");
                    break;
            }
        }
        //4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10.  
        {
            int c = 11;

            if (c > 10)
            {
                Console.WriteLine("Es mayor que 10");
            }
        }

        //5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error. 
        {

            int d = 9;

            if (d > 10)
            {
                Console.WriteLine("Es mayor que 10");
            }
            else
            {
                Console.WriteLine("No es mayor que 10");
            }
        }

        //7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar. 
        {
            int numero = 0;

            while (numero < 50)
            {
                numero += 5;
                Console.WriteLine(numero);
            }
        }
    }

    //Generalidades 
    //1)Crear una función que devuelva la suma de dos números recibidos por parámetros  
    public static int sumar(int a, int b)
    {

        int suma = a + b;

        Console.WriteLine("La suma es: " + suma);
        return suma;

    }

    //2)Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres
    public static void cutString(String a)
    {

        String myString = a;

        Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4));

    }

    //3)Crear una función que devuelva la fecha y hora actual  
    public static DateTime Now()
    {

        return DateTime.Now;

    }
    //4)Escribir un comentario con //
    public static void cutString2(String a)
    {

        // Funcion que devuelve la cadena cortada que se pasa por parametro 

        String myString = a;

        Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4));

    }

    //5)Escribir un comentario con /*   */ 
    public static void cutString3(String a)
    {

        /* Funcion que devuelve la cadena cortada que se pasa por parametro */

        String myString = a;

        Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4));
    }

    //Enumeraciones 
    //1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1. 
    public enum Days
    {

        Domingo = 1,
        Lunes = 2,
        Martes = 3,
        Miercoles = 4,
        Jueves = 5,
        Viernes = 6,
        Sabado = 7

    }

    //2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana
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