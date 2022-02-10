using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorRomanos;

namespace ConversorRomanosTest
{
    [TestClass]
    public class ConverterIndoArabicaParaRomanoTest
    {
        UnidadeIndoArabica u = new UnidadeIndoArabica();
        [TestMethod]
        public void DeveRetornarI()
        {
            Assert.AreEqual("I", u.ConverterIndoArabicaParaRomano(1));
        }
        [TestMethod]
        public void DeveRetornarII()
        {
            Assert.AreEqual("II", u.ConverterIndoArabicaParaRomano(2));
        }
        [TestMethod]
        public void DeveRetornarIII()
        {
            Assert.AreEqual("III", u.ConverterIndoArabicaParaRomano(3));
        }
        [TestMethod]
        public void DeveRetornarIV()
        {
            Assert.AreEqual("IV", u.ConverterIndoArabicaParaRomano(4));
        }
        [TestMethod]
        public void DeveRetornarV()
        {
            Assert.AreEqual("V", u.ConverterIndoArabicaParaRomano(5));
        }
        [TestMethod]
        public void DeveRetornarVIII()
        {
            Assert.AreEqual("VIII", u.ConverterIndoArabicaParaRomano(8));
        }
        [TestMethod]
        public void DeveRetornarIX()
        {
            Assert.AreEqual("IX", u.ConverterIndoArabicaParaRomano(9));
        }
        [TestMethod]
        public void DeveRetornarX()
        {
            Assert.AreEqual("X", u.ConverterIndoArabicaParaRomano(10));
        }
        [TestMethod]
        public void DeveRetornarXX()
        {
            Assert.AreEqual("XX", u.ConverterIndoArabicaParaRomano(20));
        }
        [TestMethod]
        public void DeveRetornarXL()
        {
            Assert.AreEqual("XL", u.ConverterIndoArabicaParaRomano(40));
        }
        [TestMethod]
        public void DeveRetornarL()
        {
            Assert.AreEqual("L", u.ConverterIndoArabicaParaRomano(50));
        }
        [TestMethod]
        public void DeveRetornarC()
        {
            Assert.AreEqual("C", u.ConverterIndoArabicaParaRomano(100));
        }
        [TestMethod]
        public void DeveRetornarCL()
        {
            Assert.AreEqual("CL", u.ConverterIndoArabicaParaRomano(150));
        }
        [TestMethod]
        public void DeveRetornarDXII()
        {
            Assert.AreEqual("DXII", u.ConverterIndoArabicaParaRomano(512));
        }
        [TestMethod]
        public void DeveRetornarCCCXC()
        {
            Assert.AreEqual("CCCXC", u.ConverterIndoArabicaParaRomano(390));
        }
        [TestMethod]
        public void DeveRetornarMDXII()
        {
            Assert.AreEqual("MDXII", u.ConverterIndoArabicaParaRomano(1512));
        }
        [TestMethod]
        public void DeveRetornarMMXII()
        {
            Assert.AreEqual("MMXII", u.ConverterIndoArabicaParaRomano(2012));
        }
        [TestMethod]
        public void DeveRetornarMMMXII()
        {
            Assert.AreEqual("MMMXII", u.ConverterIndoArabicaParaRomano(3012));
        }
        [TestMethod]
        public void DeveRetornarĪV̄D()
        {
            Assert.AreEqual("ĪV̄D", u.ConverterIndoArabicaParaRomano(4500));
        }
        [TestMethod]
        public void DeveRetornarV̄D()
        {
            Assert.AreEqual("V̄D", u.ConverterIndoArabicaParaRomano(5500));
        }
        [TestMethod]
        public void DeveRetornarV̄CM()
        {
            Assert.AreEqual("V̄CM", u.ConverterIndoArabicaParaRomano(5900));
        }
        [TestMethod]
        public void DeveRetornarV̄ĪD()
        {
            Assert.AreEqual("V̄ĪD", u.ConverterIndoArabicaParaRomano(6500));
        }
        [TestMethod]
        public void DeveRetornarV̄ĪĪCD()
        {
            Assert.AreEqual("V̄ĪĪCD", u.ConverterIndoArabicaParaRomano(7400));
        }
        [TestMethod]
        public void DeveRetornarV̄ĪĪĪD()
        {
            Assert.AreEqual("V̄ĪĪĪD", u.ConverterIndoArabicaParaRomano(8500));
        }
        [TestMethod]
        public void DeveRetornarĪX̄DXC()
        {
            Assert.AreEqual("ĪX̄DXC", u.ConverterIndoArabicaParaRomano(9590));
        }
        [TestMethod]
        public void DeveRetornarX̄D()
        {
            Assert.AreEqual("X̄D", u.ConverterIndoArabicaParaRomano(10500));
        }
        [TestMethod]
        public void DeveRetornarĪX̄DCCLXXXVI()
        {
            Assert.AreEqual("ĪX̄DCCLXXXVI", u.ConverterIndoArabicaParaRomano(9786));
        }
    }
}

