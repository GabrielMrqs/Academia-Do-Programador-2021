using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class JogoTests
    {
        [TestMethod]
        public void JogadorUmDeveSerVencedor()
        {
            Carta c1 = new Carta("5D 8C 9S JS AC");
            Carta c2 = new Carta("2C 5C 7D 8S QH");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 1 venceu!!!");
        }
        [TestMethod]
        public void JogadorUmDeveSerVencedor2()
        {
            Carta c1 = new Carta("4D 6S 9H QH QC");
            Carta c2 = new Carta("3D 6D 7H QD QS");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 1 venceu!!!");
        }
        [TestMethod]
        public void JogadorUmDeveSerVencedor3()
        {
            Carta c1 = new Carta("2H 2D 4C 4D 4S");
            Carta c2 = new Carta("3C 3D 3S 9S 9D");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 1 venceu!!!");
        }
        [TestMethod]
        public void JogadorDoisDeveSerVencedor()
        {
            Carta c1 = new Carta("5H 5C 6S 7S KD");
            Carta c2 = new Carta("2C 3S 8S 8D TD");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 2 venceu!!!");
        }
        [TestMethod]
        public void JogadorDoisDeveSerVencedor2()
        {
            Carta c1 = new Carta("2D 9C AS AH AC");
            Carta c2 = new Carta("3D 6D 7D TD QD");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 2 venceu!!!");
        }
        [TestMethod]
        public void JogadorTresDeveSerVencedor()
        {
            Carta c1 = new Carta("2D 9C AS AH AC");
            Carta c2 = new Carta("3D 6D 7D TD QD");
            Carta c3 = new Carta("AD KD QD JD TD");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2), new Jogador(c3) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 3 venceu!!!");
        }
        [TestMethod]
        public void JogadorTresDeveSerVencedor2()
        {
            Carta c1 = new Carta("2D 9C AS AH AC");
            Carta c2 = new Carta("KD KD KD 4H 5S");
            Carta c3 = new Carta("AD AD AD JH TD");

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(c1), new Jogador(c2), new Jogador(c3) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 3 venceu!!!");
        }
        [TestMethod]
        public void Teste()
        {
            Carta n = new Carta("5D 9C 7S 2H AC"); //normal 5
            Carta d = new Carta("KD KD 6D 4H 5S"); //dupla 6
            Carta dd = new Carta("KD KD 6D 6H 5S"); //duas duplas 7      
            Carta t = new Carta("AD AD AD JH TD"); //trinca 8
            Carta s = new Carta("TD 9D 8D 7H 6D"); //sequencia 5
            Carta f = new Carta("3D 9D 8D 7D 6D"); //flush 5
            Carta fh = new Carta("AD AD AD TH TS"); //full house 9
            Carta q = new Carta("AD AD TD AH AS"); //quadra 11
            Carta sf = new Carta("TD 9D 8D 7D 6D"); //straight flush 5
            Carta rf = new Carta("AD KD QD JD TD"); //royal flush 5

            List<Jogador> jogadores = new List<Jogador>() { new Jogador(n), new Jogador(d), new Jogador(dd), new Jogador(t), new Jogador(s),
                                                            new Jogador(f), new Jogador(fh), new Jogador(q), new Jogador(sf), new Jogador(rf) };

            Jogo jogo = new Jogo(jogadores);

            jogo.RetornarVencedor().Should().Be("O jogador 10 venceu!!!");
        }

    }
}