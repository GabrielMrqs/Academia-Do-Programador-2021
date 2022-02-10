using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Linq;
using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace AgendaJP.Tests.Tarefas
{
    [TestClass]
    public class TarefaTest
    {
        public TarefaTest()
        {
        }

        [TestMethod]
        public void ValidarTarefaCorreto()
        {
            Tarefa tarefa = new Tarefa("Alta", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            tarefa.Validar().Should().Be("");
        }
        [TestMethod]
        public void ValidarTarefaTituloIncorreto()
        {
            Tarefa tarefa = new Tarefa("Alta", "", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            tarefa.Validar().Should().Be("Titulo em branco.\n");
        }
        [TestMethod]
        public void ValidarTarefaPorcentagemIncorreta()
        {
            Tarefa tarefa = new Tarefa("Alta", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 1000);

            tarefa.Validar().Should().Be("Percentual inválido.\n");
        }
        [TestMethod]
        public void ValidarTarefaPrioridadeIncorreta()
        {
            Tarefa tarefa = new Tarefa("", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 23), 50);

            tarefa.Validar().Should().Be("Prioridade em branco.\n");
        }
        [TestMethod]
        public void ValidarTarefaDataIncorreta()
        {
            Tarefa tarefa = new Tarefa("Alta", "Fazer testes", new DateTime(2021, 06, 22), new DateTime(2021, 06, 21), 50);

            tarefa.Validar().Should().Be("Data em formato inválido.\n");
        }
       
    }
}