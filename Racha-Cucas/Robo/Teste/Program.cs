using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insira os dados para a áea: X, Y ,separados por espaço:");
                string dimensoes = Console.ReadLine();
                //PICOTANDO A STRING
                string[] separador = dimensoes.Split(' ');
                //VALIDANDO INPUTS 
                if (separador.Length != 2 || !int.TryParse(separador[0], out _) || !int.TryParse(separador[1], out _))
                {
                    Console.WriteLine("Dimensões inválidas!");
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Insira a localização inicial do Robô, separados por espaço:");
                        string inicio = Console.ReadLine();
                        //VALIDANDO INPUTS COM LETRAS MAÍSCULAS E MINÚSCULAS, E COM O NÚMERO DE DIGITOS CORRETOS
                        separador = inicio.Split(' ');
                        separador[2] = separador[2].ToUpper();
                        bool Edirecao = separador[2] == "N" || separador[2] == "O" || separador[2] == "S" || separador[2] == "L";

                        if (!Edirecao || separador.Length != 3 || !int.TryParse(separador[0], out _) || !int.TryParse(separador[1], out _) || int.TryParse(separador[2], out _))
                        {
                            Console.WriteLine("Localização inicial inválida!");
                        }
                        else
                        {   //IMPRIMINDO OS DADOS RECEBIDOS
                            int x = Convert.ToInt32(separador[0]);
                            int y = Convert.ToInt32(separador[1]);
                            string direcao = separador[2];
                            Robo robo = new Robo(x, y, direcao);
                            Console.WriteLine(robo.ToString());

                            while (true)
                            {   //RECEBENDO OUTPUTS DE COMANDOS
                                Console.WriteLine("Insira os comandos:");
                                string comandos = Console.ReadLine();
                                comandos = comandos.ToUpper();

                                for (int i = 0; i < comandos.Length; i++)
                                {
                                    if (comandos[i] == 'E') { robo.E(); }
                                    else
                                    if (comandos[i] == 'D') { robo.D(); }
                                    else
                                    if (comandos[i] == 'M') { robo.M(); }
                                    else
                                    {
                                        Console.WriteLine("Comando inválido!");    
                                    }

                                }
                                //IMPRIMINDO OS DADOS RECEBIDOS *ATUALIZADOS*
                                Console.WriteLine(robo.ToString());

                                break;
                            }

                        }
                    }

                }

            }

        }
    }
}
