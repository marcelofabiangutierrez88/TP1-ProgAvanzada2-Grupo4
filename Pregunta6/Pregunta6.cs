using System;

public class Pregunta6
{
    public static void Main()
    {
        // La instrucción for: ejecuta su cuerpo mientras una expresión booleana especificada se evalúe como true.
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
        }

        //La instrucción foreach: enumera los elementos de una colección y ejecuta su cuerpo para cada elemento de la colección.
        var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
        foreach (int element in fibNumbers)
        {
            Console.Write($"{element} ");
        }
    }
}