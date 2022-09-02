using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    public class Punto3
    {
        public string rtaPunto3(string color)
        {
            Console.WriteLine("- Punto 3 -");
            Console.WriteLine("3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado. \n");
            string rta = "";
            switch (color)
            {
                case "blanco":
                    return rta = "El color es blanco \n";
                    break;
                case "azul":
                    return rta = "El color es azul \n";
                    break;
                case "negro":
                    return rta = "El color es negro \n";
                    break;
            }
            return rta = "Vuelva a seleccionar \n";
        }
    }
}
