using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    public class Punto1
    {
        public void rtaPunto1()
        {
            Console.WriteLine("- Punto 1 -");
            Console.WriteLine("1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1. \n");
            Console.WriteLine("Enum");
            Console.WriteLine( Days.Domingo + " : " + (int) Days.Domingo);
            Console.WriteLine( Days.Lunes + " : " + (int) Days.Lunes);
            Console.WriteLine( Days.Martes + " : " + (int) Days.Martes);
            Console.WriteLine(Days.Miercoles + " : " + (int) Days.Miercoles);
            Console.WriteLine( Days.Jueves + " : " + (int) Days.Jueves);
            Console.WriteLine( Days.Viernes + " : " + (int) Days.Viernes);
            Console.WriteLine(Days.Sabado  + " : " + (int) Days.Sabado + "\n");

        }
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
    }
}


