using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;
using System;
using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace AgendaJP.Tests.Compromissos
{
    [TestClass]
    public class CompromissoTest
    {
        public CompromissoTest()
        {
        }

        [TestMethod]
        public void ValidarCompromissoCorreto()
        {
            Compromisso compromisso = new Compromisso("Fazer vaso de barro", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), null);

            compromisso.Validar().Should().Be("");
        }
        [TestMethod]
        public void ValidarCompromissoAssuntoIncorreto()
        {
            Compromisso compromisso = new Compromisso("", "Casa da minha vó", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), null);

            compromisso.Validar().Should().Be("Assunto em branco.\n");
        }
        [TestMethod]
        public void ValidarCompromissoLocalIncorreto()
        {
            Compromisso compromisso = new Compromisso("Cortar grama", "", new DateTime(2021, 06, 22, 10, 00, 00),
               new DateTime(2021, 06, 22, 12, 00, 00), null);
            compromisso.Validar().Should().Be("Local em branco.\n");
        }
    }
}