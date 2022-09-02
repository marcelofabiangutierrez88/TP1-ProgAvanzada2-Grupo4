using System;

public class Pregunta6
{
    public static void Main()
    {
        //¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?


        // La instrucción for: ejecuta su cuerpo mientras una expresión booleana especificada se evalúe como true.
        // El bucle for se puede utilizar cuando en el cuerpo es necesario obtener la posicion del array
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
        }

        // La instrucción foreach: enumera los elementos de una colección y ejecuta su cuerpo para cada elemento de la colección.
        // foreach mantiene una sintaxis mas clara a la hora de poder analizarlo
        var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
        foreach (int element in fibNumbers)
        {
            Console.Write($"{element} ");
        }
    }
}