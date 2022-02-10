using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Robo
    {
        private int x;
        private int y;
        private string direcao;

        public Robo(int x, int y, string direcao)//DECLARANDO OS DADOS
        {
            this.x = x;
            this.y = y;
            this.direcao = direcao;
        }
        public override string ToString()//TOSTRING PARA IMPRESSÃO
        {
            return "X: " + x + " Y: " + y + " Direção: " + direcao.ToUpper();
        }
        public void M()//ANDAR PARA FRENTE
        {
            if (direcao == "N") { y++; }else
            if (direcao == "S") { y--; }else
            if (direcao == "L") { x++; }else
            if (direcao == "O") { x--; }
        }
        public void D()//VIRAR PARA A DIREITA
        {
            if (direcao == "N") { direcao = "L"; }else
            if (direcao == "S") { direcao = "O"; }else
            if (direcao == "L") { direcao = "S"; }else
            if (direcao == "O") { direcao = "N"; }
        }
        public void E()//VIRAR PARA A ESQUERDA
        {
            if (direcao == "N") { direcao = "O"; }else
            if (direcao == "S") { direcao = "L"; }else
            if (direcao == "L") { direcao = "N"; }else
            if (direcao == "O") { direcao = "S"; }
        }
        
    }
}

