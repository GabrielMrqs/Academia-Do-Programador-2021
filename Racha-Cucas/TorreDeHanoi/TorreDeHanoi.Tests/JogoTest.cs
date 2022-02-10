using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TorreDeHanoi.Tests
{
    [TestClass]
    public class JogoTest
    {
        [TestMethod]
        public void Deve_retornar_7()
        {
            Torre torre = new(3);

            Jogo jogo = new(torre);

            var movimentos = jogo.RealizarMovimentos();

            movimentos.Should().Be(7);
        }
        [TestMethod]
        public void Deve_retornar_15()
        {
            Torre torre = new(4);

            Jogo jogo = new(torre);

            var movimentos = jogo.RealizarMovimentos();

            movimentos.Should().Be(15);
        }
        [TestMethod]
        public void Deve_retornar_31()
        {
            Torre torre = new(5);

            Jogo jogo = new(torre);

            var movimentos = jogo.RealizarMovimentos();

            movimentos.Should().Be(31);
        }
        [TestMethod]
        public void Deve_retornar_63()
        {
            Torre torre = new(6);

            Jogo jogo = new(torre);

            var movimentos = jogo.RealizarMovimentos();

            movimentos.Should().Be(63);
        }
        [TestMethod]
        public void Deve_retornar_127()
        {
            Torre torre = new(7);

            Jogo jogo = new(torre);

            var movimentos = jogo.RealizarMovimentos();

            movimentos.Should().Be(127);
        }
        [TestMethod]
        public void Deve_retornar_255()
        {
            Torre torre = new(8);

            Jogo jogo = new(torre);

            var movimentos = jogo.RealizarMovimentos();

            movimentos.Should().Be(255);
        }
    }
}
