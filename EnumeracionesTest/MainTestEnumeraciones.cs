using Enumeraciones;

namespace EnumeracionesTest
{
    [TestClass]
    public class MainTestEnumeraciones
    {
        [TestMethod]
        public void mainTest()
        {
            Punto1 punto1 = new Punto1();
            Punto2 punto2 = new Punto2();
            
            Assert.IsNotNull(punto1);
            Assert.IsNotNull(punto2);
        }
    }
}