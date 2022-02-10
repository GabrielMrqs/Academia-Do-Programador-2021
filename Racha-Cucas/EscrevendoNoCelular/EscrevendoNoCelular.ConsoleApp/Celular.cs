using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Celular : Conversoes
    {
        private string numero;
        public string Numero { get => numero;}

        public Celular(string numero)
        {
            this.numero = numero;
        }
    }
}
