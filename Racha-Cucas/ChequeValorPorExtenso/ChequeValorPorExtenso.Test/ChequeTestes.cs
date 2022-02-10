using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequeValorPorExtenso.ConsoleApp;

namespace ChequeValorPorExtenso.Test
{
    [TestClass]
    public class Teste
    {
        Cheque cheque = new Cheque(0);

        [TestMethod] 
        public void DeveRetornar1Centavo()
        {
            Assert.AreEqual("um centavo de real", cheque.RetornaValorPorExtenso(0.01m));
        }
        [TestMethod]
        public void DeveRetornar10Centavos()
        {
            Assert.AreEqual("dez centavos de real", cheque.RetornaValorPorExtenso(0.10m));
        }
        [TestMethod]
        public void DeveRetornar15Centavos()
        {
            Assert.AreEqual("quinze centavos de real", cheque.RetornaValorPorExtenso(0.15m));
        }
        [TestMethod]
        public void DeveRetornar99Centavos()
        {
            Assert.AreEqual("noventa e nove centavos de real", cheque.RetornaValorPorExtenso(0.99m));
        }
        [TestMethod]
        public void DeveRetornar1Real()
        {
            Assert.AreEqual("um real", cheque.RetornaValorPorExtenso(1));
        }
        [TestMethod]
        public void DeveRetornar1RealE16Centavos()
        {
            Assert.AreEqual("um real e dezesseis centavos de real", cheque.RetornaValorPorExtenso(1.16m));
        }
        [TestMethod]
        public void DeveRetornar1RealE30Centavos()
        {
            Assert.AreEqual("um real e trinta centavos de real", cheque.RetornaValorPorExtenso(1.30m));
        }
        [TestMethod]
        public void DeveRetornar7ReaisE85Centavos()
        {
            Assert.AreEqual("sete reais e oitenta e cinco centavos de real", cheque.RetornaValorPorExtenso(7.85m));
        }
        [TestMethod]
        public void DeveRetornar13Reais()
        {
            Assert.AreEqual("treze reais", cheque.RetornaValorPorExtenso(13));
        }
        [TestMethod]
        public void DeveRetornar20ReaisE50Centavos()
        {
            Assert.AreEqual("vinte reais e cinquenta centavos de real", cheque.RetornaValorPorExtenso(20.50m));
        }
        [TestMethod]
        public void DeveRetornar100Reais()
        {
            Assert.AreEqual("cem reais", cheque.RetornaValorPorExtenso(100));
        }
        [TestMethod]
        public void DeveRetornar103Reais()
        {
            Assert.AreEqual("cento e três reais", cheque.RetornaValorPorExtenso(103));
        }
        [TestMethod]
        public void DeveRetornar500Reais()
        {
            Assert.AreEqual("quinhentos reais", cheque.RetornaValorPorExtenso(500));
        }
        [TestMethod]
        public void DeveRetornar1000Reais()
        {
            Assert.AreEqual("um mil reais", cheque.RetornaValorPorExtenso(1000));
        }
        [TestMethod]
        public void DeveRetornar1526Reais45Centavos()
        {
            Assert.AreEqual("um mil quinhentos e vinte e seis reais e quarenta e cinco centavos de real", cheque.RetornaValorPorExtenso(1526.45m));
        }
        [TestMethod]
        public void DeveRetornar1000Reais45Centavos()
        {
            Assert.AreEqual("um mil reais e quarenta e cinco centavos de real", cheque.RetornaValorPorExtenso(1000.45m));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoDeReais()
        {
            Assert.AreEqual("um milhão de reais", cheque.RetornaValorPorExtenso(1000000));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoE1DeReais()
        {
            Assert.AreEqual("um milhão e um real", cheque.RetornaValorPorExtenso(1000001));
        }
        [TestMethod]
        public void DeveRetornar1Milhao137Mil147Reais()
        {
            Assert.AreEqual("um milhão cento e trinta e sete mil cento e quarenta e sete reais", cheque.RetornaValorPorExtenso(1137147));
        }
        [TestMethod]
        public void DeveRetornar1Milhao1147Reais()
        {
            Assert.AreEqual("um milhão um mil cento e quarenta e sete reais", cheque.RetornaValorPorExtenso(1001147));
        }
        [TestMethod]
        public void DeveRetornar1Milhao410Mil957ReaisE13Centavos()
        {
            Assert.AreEqual("um milhão quatrocentos e dez mil novecentos e cinquenta e sete reais e treze centavos de real", cheque.RetornaValorPorExtenso(1410957.13m));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoE47Reais()
        {
            Assert.AreEqual("um milhão e quarenta e sete reais", cheque.RetornaValorPorExtenso(1000047));
        }
        [TestMethod]
        public void DeveRetornar1MilhaoDeReaisE147Centavos()
        {
            Assert.AreEqual("um milhão de reais e quarenta e sete centavos de real", cheque.RetornaValorPorExtenso(1000000.47m));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoDeReais()
        {
            Assert.AreEqual("um bilhão de reais", cheque.RetornaValorPorExtenso(1000000000));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoDeReaisE1Centavo()
        {
            Assert.AreEqual("um bilhão de reais e um centavo de real", cheque.RetornaValorPorExtenso(1000000000.01m));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoE1DeReais()
        {
            Assert.AreEqual("um bilhão e um real", cheque.RetornaValorPorExtenso(1000000001));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoE100DeReais()
        {
            Assert.AreEqual("um bilhão e cem reais", cheque.RetornaValorPorExtenso(1000000100));
        }
        [TestMethod]
        public void DeveRetornar1BilhaoE100DeReaisE67Centavos()
        {
            Assert.AreEqual("um bilhão e cem reais e sessenta e sete centavos de real", cheque.RetornaValorPorExtenso(1000000100.67m));
        }
        [TestMethod]
        public void DeveRetornar1TrilhaoDeReais()
        {
            Assert.AreEqual("um trilhão de reais", cheque.RetornaValorPorExtenso(1000000000000));
        }
        [TestMethod]
        public void DeveRetornar1TrilhaoDeReaisE50Centavos()
        {
            Assert.AreEqual("um trilhão de reais e cinquenta centavos de real", cheque.RetornaValorPorExtenso(1000000000000.50m));
        }
        [TestMethod]
        public void DeveRetornar1TrilhaoDeE147ReaisE12Centavos()
        {
            Assert.AreEqual("um trilhão e cento e quarenta e sete reais e doze centavos de real", cheque.RetornaValorPorExtenso(1000000000147.12m));
        }
        [TestMethod]
        public void DeveRetornar300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos de real", cheque.RetornaValorPorExtenso(300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar400Trilhões300Bilhoes15Milhoes10Mil517ReaisE39Centavos()
        {
            Assert.AreEqual("quatrocentos trilhões trezentos bilhões quinze milhões dez mil quinhentos e dezessete reais e trinta e nove centavos de real", cheque.RetornaValorPorExtenso(400300015010517.39m));
        }
        [TestMethod]
        public void DeveRetornar69Trilhões69Bilhoes69Milhoes420Mil420ReaisE69Centavos()
        {
            Assert.AreEqual("sessenta e nove trilhões sessenta e nove bilhões sessenta e nove milhões quatrocentos e vinte mil quatrocentos e vinte reais e sessenta e nove centavos de real", cheque.RetornaValorPorExtenso(69069069420420.69m));
        }
        [TestMethod]
        public void DeveRetornar1Quadrilhão()
        {
            Assert.AreEqual("Quantidade inválida", cheque.RetornaValorPorExtenso(1000000000000000m));
        }
    }
}


