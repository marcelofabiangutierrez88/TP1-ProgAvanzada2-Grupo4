using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    public class Punto6
    {
        public void rtaPunto6()
        {
            Console.WriteLine("- Punto 6 -");
            Console.WriteLine("6) ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas? \n");
            Console.WriteLine("La diferencia principal entre el las sentencias for y el foreach es que, el for recorre un array hasta la posicion que indicamos que recorrra," +
                " en cambio el foreach recorre de principio a fin. \r\n\r\nAdemas, foreach no es un bucle si no mas bien un constructor el cual solo puede iterar en arrays y objetos." +
                " For es bucle que nosotros podemos decir hasta donde se tiene que repetir. \r\n\r\nForeach no se puede utilizar para recorrer strings. \n");
        }
    }
}
