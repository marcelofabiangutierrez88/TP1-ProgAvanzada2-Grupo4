using static Ejercicio2;

namespace testEjercicio2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEjercicio2()
        {
            string text = "avanzada";
            string esperado = "avan";
            Assert.AreEqual(esperado, cutString(text));
        }
    }
}