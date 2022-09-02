using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    public class Punto2
    {
        public void rtaPunto2()
        {
            Console.WriteLine("- Punto 2 -");
            Console.WriteLine("2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana. \n");

            Days lunesUno = Days.Lunes;
            int lunes = (int)Days.Lunes;
            Console.WriteLine("Hoy es " + lunesUno + ", es el dia " + lunes + " de la semana \n");
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
