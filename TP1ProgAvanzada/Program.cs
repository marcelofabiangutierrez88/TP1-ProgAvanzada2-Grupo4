using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static TP1ProgAvanzada.Program;

namespace TP1ProgAvanzada
{
    public class Program
    {
        static void Main(string[] args)
        {
            dias lunesUno = dias.Lunes;

            int lunes = (int)dias.Lunes;

            Console.WriteLine("Hoy es " + lunesUno + ", es el dia " + lunes + " de la semana");
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
        public static String cutString(String a)
        {

            String myString = a;
            

            Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4));

            return myString;
        }

        //3)Crear una función que devuelva la fecha y hora actual  
        public static DateTime fecha()
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
            Sabado = 7,

        }
        //Conversiones
        //1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados. 

        /* 2) Explique que sucede en los siguientes intentos de casteos de datos.
         a) int a = (int)344.4;
        En el primer caso, al ser un int y castear en un int lo que devuelve es el valor entero del numero: 344 
         b) decimal a = 10;
        En este caso, al no tener decimales muestra el valor entero : 10 
         c) int a = 443444;
        El 44344 es un valor entero, por ende no pasa nada.
        d) short b = (short)a;
        Los dos tipos de datos son iguales(short) en este caso el casteo no haria nada.*/

        //3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.
        public static String ejercicio3(String color)
        {
        color = "blanco";

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
            return color;
        }
        //4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10.  
        public static int ejercicio4(int c)
        {
        c = 11;

        if (c > 10)
        {
        Console.WriteLine("Es mayor que 10");
        }
            return c;
        }

        //5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error. 
        public static void ejercicio5()
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
        /*6) ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas? 

        La diferencia principal entre el las sentencias for y el foreach es que, el for recorre un array hasta la posicion que indicamos que recorrra, en cambio el foreach recorre de principio a fin.
        Ademas, foreach no es un bucle si no mas bien un constructor el cual solo puede iterar en arrays y objetos.For es bucle que nosotros podemos decir hasta donde se tiene que repetir.
        Foreach no se puede utilizar para recorrer strings.*/

        //7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar. 
        public static void ejercicio7()
        {
        int numero = 0;

        while (numero < 50)
        {
        numero += 5;
        Console.WriteLine(numero);
        }
}
}
}
