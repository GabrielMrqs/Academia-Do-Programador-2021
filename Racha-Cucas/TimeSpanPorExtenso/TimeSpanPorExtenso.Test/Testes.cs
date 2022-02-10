using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeSpanPorExtenso.ConsoleApp;
using System;

namespace TimeSpanPorExtenso.Test
{
    [TestClass]
    public class Testes
    {
        Data data = new Data(new DateTime(2001, 01, 01, 00, 00, 00));
        [TestMethod]
        public void DeveRetornarUmSegundo()
        {
            DateTime dataPassada = new DateTime(2001, 01, 01, 00, 00, 01);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um segundo atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisSegundos()
        {
            DateTime dataPassada = new DateTime(2001, 01, 01, 00, 00, 02);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois segundos atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmMinuto()
        {
            DateTime dataPassada = new DateTime(2001, 01, 01, 00, 01, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um minuto atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisMinutos()
        {
            DateTime dataPassada = new DateTime(2001, 01, 01, 00, 02, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois minutos atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmaHora()
        {
            DateTime dataPassada = new DateTime(2001, 01, 01, 01, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("uma hora atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDuasHoras()
        {
            DateTime dataPassada = new DateTime(2001, 01, 01, 02, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("duas horas atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmDia()
        {
            DateTime dataPassada = new DateTime(2001, 01, 02, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um dia atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisDias()
        {
            DateTime dataPassada = new DateTime(2001, 01, 03, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois dias atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmMes()
        {
            DateTime dataPassada = new DateTime(2001, 02, 01, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um mês atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisMeses()
        {
            DateTime dataPassada = new DateTime(2001, 03, 01, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois meses atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmAno()
        {
            DateTime dataPassada = new DateTime(2002, 01, 01, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um ano atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisAnos()
        {
            DateTime dataPassada = new DateTime(2003, 01, 01, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois anos atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmAnoUmMes()
        {
            DateTime dataPassada = new DateTime(2002, 02, 01, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um ano um mês atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisAnosDoisMeses()
        {
            DateTime dataPassada = new DateTime(2003, 03, 01, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois anos dois meses atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmAnoUmMesUmDia()
        {
            DateTime dataPassada = new DateTime(2002, 02, 02, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um ano um mês um dia atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisAnosDoisMesesDoisDias()
        {
            DateTime dataPassada = new DateTime(2003, 03, 03, 00, 00, 00);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois anos dois meses dois dias atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarUmAnoUmDiaUmMesUmSegundo()
        {
            DateTime dataPassada = new DateTime(2002, 02, 02, 00, 00, 01);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um ano um mês um dia um segundo atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisAnosDoisMesesDoisDiasDoisSegundos()
        {
            DateTime dataPassada = new DateTime(2003, 03, 03, 00, 00, 02);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois anos dois meses dois dias dois segundos atrás", data.Retornar());
        }   
        [TestMethod]
        public void DeveRetornarUmAnoUmMesUmDiaUmMinutoUmSegundo()
        {
            DateTime dataPassada = new DateTime(2002, 02, 02, 00, 01, 01);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um ano um mês um dia um minuto um segundo atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisAnosDoisMesesDoisDiasDoisMinutosDoisSegundos()
        {
            DateTime dataPassada = new DateTime(2003, 03, 03, 00, 02, 02);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois anos dois meses dois dias dois minutos dois segundos atrás", data.Retornar());
        }      
        [TestMethod]
        public void DeveRetornarUmAnoUmMesUmDiaUmaHoraUmMinutoUmSegundo()
        {
            DateTime dataPassada = new DateTime(2002, 02, 02, 01, 01, 01);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("um ano um mês um dia uma hora um minuto um segundo atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarDoisAnosDoisMesesDoisDiasDuasHorasDoisMinutosDoisSegundos()
        {
            DateTime dataPassada = new DateTime(2003, 03, 03, 02, 02, 02);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("dois anos dois meses dois dias duas horas dois minutos dois segundos atrás", data.Retornar());
        }
        [TestMethod]
        public void DeveRetornarVinteEDoisAnosDoisMesesVinteETresDiasEOnzeHorasVinteETresminutosQuarentaESeteSegundos()
        {
            DateTime dataPassada = new DateTime(2023, 08, 24, 11, 23, 47);
            data.Separar(data.TimeSpan(data.DataDeComparacao, dataPassada));
            Assert.AreEqual("vinte e dois anos sete meses vinte e três dias onze horas vinte e três minutos quarenta e sete segundos atrás", data.Retornar());
        }
    }
}
