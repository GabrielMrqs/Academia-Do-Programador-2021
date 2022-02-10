namespace Poker
{
    public class Jogador
    {
        public Jogador(Carta cartas)
        {
            Cartas = cartas;
        }

        public Carta Cartas { get; }
        public double Pontos { get; set; }
    }
}