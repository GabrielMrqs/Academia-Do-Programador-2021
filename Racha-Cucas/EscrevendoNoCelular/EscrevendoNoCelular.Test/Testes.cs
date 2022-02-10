using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscrevendoNoCelular.ConsoleApp;

namespace EscrevendoNoCelular.Test
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void DeveRetornar77773367_7773302_222337777_777766606660366656667889999_9999555337777()
        {
            Celular celular = new Celular("SEMPRE ACESSO O DOJOPUZZLES");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", celular.SepararLetras(celular.Numero));
        }
        [TestMethod]
        public void DeveRetornar26_6660277770288555277770366607773322244()
        {
            Celular celular = new Celular("AMO AS AULAS DO RECH");
            Assert.AreEqual("26_6660277770288555277770366607773322244", celular.SepararLetras(celular.Numero));
        }
        [TestMethod]
        public void DeveRetornar83377778266366608860366644477770833777782663666()
        {
            Celular celular = new Celular("TESTANDO UM DOIS TESTANDO");
            Assert.AreEqual("83377778266366608860366644477770833777782663666", celular.SepararLetras(celular.Numero));
        }
        [TestMethod]
        public void DeveRetornar42_2277744433555062777_7788337777()
        {
            Celular celular = new Celular("GABRIEL MARQUES");
            Assert.AreEqual("42_2277744433555062777_7788337777", celular.SepararLetras(celular.Numero));
        }
    }
}
