using static Ejercicio6;

namespace testEjercicio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEnum()
        {
            int esperado = 3;
            Assert.AreEqual(esperado, Convert.ToInt16(Dias.Martes));
            Assert.IsNotNull(Dias.Martes);
        }
    }
}