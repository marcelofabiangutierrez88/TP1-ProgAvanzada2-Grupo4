using Generalidades;
namespace GeneralidadesTestt
{
    [TestClass]
    public class MainGeneralidadesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Punto1 punto1 = new Punto1();
            Punto2 punto2 = new Punto2();
            Punto3 punto3 = new Punto3();
            Punto4 punto4 = new Punto4();
            Punto5 punto5 = new Punto5();

            Assert.IsNotNull(punto1);
            Assert.IsNotNull(punto2);
            Assert.IsNotNull(punto3);
            Assert.IsNotNull(punto4);
            Assert.IsNotNull(punto5);
        }
    }
}