// Se genera clase de test con scope a cada punto del TP, en este caso se abarcan los puntos de la seccion Generalidades.
namespace TestGeneralidades
{
    [TestClass]
    public class GeneralidadesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // defino resultados de los metodos.
            /*
             * Ejercicio1
             */
            int result = GeneralidadesEjercicio1.sumar(4, 5);
            int esperado = 9;

            /*
             * Ejercicio2
             */
            String cadena = "avanzada";
            String cadenaCortada = "avan";

            // valido resultados
            Assert.AreEqual(result, esperado);
            Assert.AreEqual(cadenaCortada, GeneralidadesEjercicio2.cutString(cadena));
            /*
             * Ejercicio3
             */
            Assert.IsNotNull(GeneralidadesEjercicio3.Now());

        }
    }
}