namespace triangulos.ConsoleApp
{
    public class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;
        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }
        public bool TrianguloValido()
        {
            bool triangulo = false;

            if (ladoA + ladoB < ladoC || ladoA + ladoC < ladoB || ladoB + ladoC < ladoA)
            { triangulo = false; }

            else if (ladoA != 0 && ladoB != 0 && ladoC != 0)
            { triangulo = true; }

            else
            { triangulo = false; }

            return triangulo;
        }
        public string TrianguloTipo()
        {
            if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
            { return "Triângulo Equilátero"; }

            else if ((ladoA == ladoB & ladoA != ladoC) || (ladoB == ladoC & ladoB != ladoA) || (ladoC == ladoA & ladoC != ladoB))
            { return "Triângulo Isóceles"; }

            else { return "Triângulo Escaleno"; }
        }
    }
}