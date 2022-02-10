using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangulos.ConsoleApp;

namespace triangulos.Tests
{
    [TestClass]
    public class TesteTriangulo
    {
        [TestMethod]
        public void TestarTriangulos()
        {
            Triangulo trianguloEquilatero = new Triangulo(3,3,3);
            Triangulo trianguloEscaleno = new Triangulo(1,2,3);
            Triangulo trianguloIsoceles = new Triangulo(3,2,3);
            Triangulo trianguloInvalido = new Triangulo(0,1,2);

            Assert.AreEqual("Triângulo Equilátero", trianguloEquilatero.TrianguloTipo());
            Assert.AreEqual("Triângulo Escaleno", trianguloEscaleno.TrianguloTipo());
            Assert.AreEqual("Triângulo Isóceles", trianguloIsoceles.TrianguloTipo());
            Assert.AreEqual(false, trianguloInvalido.TrianguloValido());
        }
    }
}
