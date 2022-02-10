using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi
{
    public class Jogo
    {
        public Torre Torre { get; set; }
        public Jogo(Torre torre)
        {
            Torre = torre;
        }



        public double RealizarMovimentos()
        {
            return Math.Pow(2, Torre.Discos) - 1;
        }
    }
}
