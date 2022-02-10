using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorRomanos;

namespace ConversorRomanosTest
{
    [TestClass]
    public class ConverterRomanoParaIndoArabicoTest
    {
        UnidadeRomana u = new UnidadeRomana();
        [TestMethod]
        public void DeveRetornar1()
        {
            Assert.AreEqual(1, u.ConverterRomanoParaIndoArabico("I"));
        }
        [TestMethod]
        public void DeveRetornar2()
        {
            Assert.AreEqual(2, u.ConverterRomanoParaIndoArabico("II"));
        }
        [TestMethod]
        public void DeveRetornar4()
        {
            Assert.AreEqual(4, u.ConverterRomanoParaIndoArabico("IV"));
        }
        [TestMethod]
        public void DeveRetornar9()
        {
            Assert.AreEqual(9, u.ConverterRomanoParaIndoArabico("IX"));
        }
        [TestMethod]
        public void DeveRetornar16()
        {
            Assert.AreEqual(16, u.ConverterRomanoParaIndoArabico("XVI"));
        }
        [TestMethod]
        public void DeveRetornar57()
        {
            Assert.AreEqual(57, u.ConverterRomanoParaIndoArabico("LVII"));
        }
        [TestMethod]
        public void DeveRetornar559()
        {
            Assert.AreEqual(559, u.ConverterRomanoParaIndoArabico("DLIX"));
        }
        [TestMethod]
        public void DeveRetornar1099()
        {
            Assert.AreEqual(1099, u.ConverterRomanoParaIndoArabico("MXCIX"));
        }
        [TestMethod]
        public void DeveRetornar2346()
        {
            Assert.AreEqual(2346, u.ConverterRomanoParaIndoArabico("MMCCCXLVI"));
        }
        [TestMethod]
        public void DeveRetornar4000()
        {
            Assert.AreEqual(4000, u.ConverterRomanoParaIndoArabico("ĪV̄"));
        }
        [TestMethod]
        public void DeveRetornar5300()
        {
            Assert.AreEqual(5300, u.ConverterRomanoParaIndoArabico("V̄CCC"));
        }
        [TestMethod]
        public void DeveRetornar9346()
        {
            Assert.AreEqual(9346, u.ConverterRomanoParaIndoArabico("ĪX̄CCCXLVI"));
        }
        [TestMethod]
        public void DeveRetornar4346()
        {
            Assert.AreEqual(4346, u.ConverterRomanoParaIndoArabico("ĪV̄CCCXLVI"));
        }
        [TestMethod]
        public void DeveRetornar7000()
        {
            Assert.AreEqual(7000, u.ConverterRomanoParaIndoArabico("V̄ĪĪ"));
        }
        [TestMethod]
        public void DeveRetornar8000()
        {
            Assert.AreEqual(8000, u.ConverterRomanoParaIndoArabico("V̄ĪĪĪ"));
        }
    }
}

