using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;
using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;

namespace AgendaJP.Tests.Contatos
{
    [TestClass]
    public class ContatoTest
    {
        public ContatoTest()
        {
        }

        [TestMethod]
        public void ValidarContatoCorreto()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "(49)99803-5074", "NDD", "DESENVOLVEDOR");

            contato.Validar().Should().Be("");
        }
        [TestMethod]
        public void ValidarContatoNomeIncorreto()
        {
            Contato contato = new Contato("", "Juca1990@gmail.com", "(49)99803-5074", "NDD", "DESENVOLVEDOR");

            contato.Validar().Should().Be("Nome em branco.\n");
        }
        [TestMethod]
        public void ValidarContatoEmailFormatoIncorreto()
        {
            Contato contato = new Contato("Juca", "Juca1990@.com", "(49)99803-5074", "NDD", "DESENVOLVEDOR");

            contato.Validar().Should().Be("E-mail em formato inválido.\n");
        }
        [TestMethod]
        public void ValidarContatoEmailEmBranco()
        {
            Contato contato = new Contato("Juca", "", "(49)99803-5074", "NDD", "DESENVOLVEDOR");

            contato.Validar().Should().Be("E-mail em branco.\n");
        }
        [TestMethod]
        public void ValidarContatoNumeroIncorreto()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "", "NDD", "DESENVOLVEDOR");

            contato.Validar().Should().Be("Telefone em formato inválido.\n");
        }
        [TestMethod]
        public void ValidarContatoEmpresaIncorreta()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "(49)99803-5074", "", "DESENVOLVEDOR");

            contato.Validar().Should().Be("Empresa em branco.\n");
        }
        [TestMethod]
        public void ValidarContatoCargoIncorreto()
        {
            Contato contato = new Contato("Juca", "Juca1990@gmail.com", "(49)99803-5074", "NDD", "");

            contato.Validar().Should().Be("Cargo em branco.\n");
        }
    }
}