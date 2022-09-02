using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalidades
{
    public class Punto2
    {
        public void rtaPunto2(String a)
        {
            Console.WriteLine("- Punto 2 -");
            Console.WriteLine("2)Crear una función que reciba una cadena de 8 caracteres y " +
                "retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres. \n");

            String myString = a;
            Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4) + "\n");
        }
    }
}
