using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string rta = Program.DimeColor("blanco");
            Assert.AreEqual("El color es blanco", rta);

        }
    }
}