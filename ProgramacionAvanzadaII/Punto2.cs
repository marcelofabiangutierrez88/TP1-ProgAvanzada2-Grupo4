using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    public class Punto2
    {
        public void rtaPunto2()
        {
            Console.WriteLine("- Punto 2 -");
            Console.WriteLine("2) Explique que sucede en los siguientes intentos de casteos de datos. \n");
            Console.WriteLine("a) int a = (int)344.4;");
            Console.WriteLine("En el primer caso, al ser un int y castear en un int lo que devuelve es el valor entero del numero: 344. \n");
            Console.WriteLine("b) decimal a = 10;");
            Console.WriteLine("En este caso, al no tener decimales muestra el valor entero : 10. \n");
            Console.WriteLine("c) int a = 443444;");
            Console.WriteLine("El 44344 es un valor entero, por ende no pasa nada. \n");
            Console.WriteLine("d) short b = (short)a;");
            Console.WriteLine("Los dos tipos de datos son iguales(short) en este caso el casteo no haria nada. \n");
        }

    }
}
