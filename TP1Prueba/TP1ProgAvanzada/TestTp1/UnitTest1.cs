using System.Drawing;
using TP1ProgAvanzada;

namespace TestTp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EjercicioGeneralidades1()
        {
            int a = 10;
            int b = 12;
            int esperado = a + b;

            int obtenido = Program.sumar(a, b);

            Assert.AreEqual(esperado, obtenido);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void EjercicioGeneralidades2()
        {
            String a = "avanzada";
            String cadenaCortada = "avan";

            Assert.AreEqual(Program.cutString(a), cadenaCortada);
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void EjercicioGeneralidades3()
        {
            Assert.IsNotNull(Program.fecha());
        }
    }
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void EjercicioEnum2()
        {
            int dia = 2;
            Assert.AreEqual(Program.Enumeracion2(), dia);
        }
    }
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void EjercicioConv3()
        {
            String result = "blanco";

            Assert.AreEqual(Program.ejercicio3("blanco"), result);

        }
    }
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void EjercicioConv4()
        {
            String numEvaluado = Program.ejercicio4(11);

            Assert.AreEqual("Es mayor que 10", numEvaluado);
        }
    }
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void EjercicioConv5()
        {
            String numEvaluado = Program.ejercicio5(11);
            Assert.AreEqual("Es mayor que 10", numEvaluado);

            String numEvaluado2 = Program.ejercicio5(6);
            Assert.AreEqual("No es mayor que 10", numEvaluado2);
        }
    }
    [TestClass]
    public class UnitTest11
    {
        [TestMethod]
        public void EjercicioConv7()
        {

        }
    }
}