using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    class GeradorID
    {
        private static int idCaixa = 0;
        private static int idRevista = 0;
        private static int idAmiguinho = 0;
        private static int idEmprestimo = 0;

        public static int IdCaixa { get => ++idCaixa; }
        public static int IdRevista { get => ++idRevista; }
        public static int IdAmiguinho { get => ++idAmiguinho; }
        public static int IdEmprestimo { get => ++idEmprestimo; }
    }
}
