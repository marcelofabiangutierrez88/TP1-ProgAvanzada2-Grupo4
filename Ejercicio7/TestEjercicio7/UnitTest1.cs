using static Ejercicio7;

namespace TestEjercicio7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEjercicio7()
        {
            int prueba = 10;
            Validation(prueba);

            Assert.AreEqual(10,prueba);
        }
    }
}