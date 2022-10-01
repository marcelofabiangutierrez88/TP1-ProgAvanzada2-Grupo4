// Se genera clase de test con scope a cada punto del TP, en este caso se abarcan los puntos de la seccion Conversiones.

namespace TestConversiones
{
    [TestClass]
    public class TestConversiones
    {
        [TestMethod]
        public void TestMethod1()
        {
  
            /*
             * Conversiones Ejercicio3
             */
            String result = "El color es blanco";
            Assert.AreEqual(ConverEjercicio3.ValidateColor("blanco"), result);

            /*
             * Conversiones Ejercicio4
             */
            int numEvaluado = 15;
            Assert.AreEqual(ConverEjercicio4.validateNumber(15), numEvaluado);

            /*
             * Conversiones Ejercicio5
             */
            int numEvaluadoEj5 = 8;
            Assert.AreEqual(ConverEjercicio5.validateNumberGreaterThanTen(8), numEvaluadoEj5);

            /*
             * Conversiones Ejercicio7
             */
            Assert.IsNotNull(ConverEjercicio7.CycleNumber(5));
           
        }
    }
}