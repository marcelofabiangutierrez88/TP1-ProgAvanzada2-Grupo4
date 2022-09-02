using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    public class Punto1
    {
        public void RtaPunto1()
        {
            Console.WriteLine("- Punto 1 -");
            Console.WriteLine("1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados. \n");
            Console.WriteLine("bool.Parse funciona pasandole por parametros un valor de tipo string a un boolean \n");
            bool valorTrue = bool.Parse("true");
            Console.WriteLine("Convierte de String Value True a bool -> " + valorTrue);
            bool valorFalse = bool.Parse("false");
            Console.WriteLine("Convierte de String Value False a bool -> " + valorFalse + "\n");

            Console.WriteLine("Convert.ToBoolean funciona pasandole un valor y el mismo intentará conviertirlo a boolean \n");
            bool valorNum0 = Convert.ToBoolean(0);
            Console.WriteLine("Convierte de Number Value 0 a bool -> " + valorNum0);
            bool valorNum1 = Convert.ToBoolean(1);
            Console.WriteLine("Convierte de Number Value 1 a bool -> " + valorNum1 + "\n");
        }
    }
}
