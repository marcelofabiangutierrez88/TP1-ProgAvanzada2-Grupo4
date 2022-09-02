using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    public class Punto7
    {
        public void rtaPunto7()
        {
            Console.WriteLine("- Punto 7 -");
            Console.WriteLine("7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. " +
                "Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar. \n");
            int numero = 0;
            while (numero < 50)
            {
                numero += 5;
                Console.WriteLine(numero);
            }
            Console.WriteLine("Numero final " + numero + "\n");
        }
    }
}
