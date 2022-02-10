using ClubeDaLeitura.ConsoleApp.Controladores;
using ClubeDaLeitura.ConsoleApp.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            while (true)
            {
                TelaBase telaSelecionada = telaPrincipal.ObterTela();
                if (telaSelecionada == null)
                    continue;

                telaSelecionada.Menu();
            }
        }
    }
}

