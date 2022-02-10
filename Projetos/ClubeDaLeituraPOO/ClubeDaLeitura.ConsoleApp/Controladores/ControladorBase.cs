using ClubeDaLeitura.ConsoleApp.Domínios;
using System.Collections.Generic;

namespace ClubeDaLeitura.ConsoleApp.Controladores
{
    abstract class ControladorBase<T>
    {
        private int capacidade;
        protected List<Registro<T>> Registros;

        public ControladorBase(int capacidade)
        {
            this.capacidade = capacidade;
            Registros = new List<Registro<T>>();
        }

        public abstract void Registrar(int id, T registro);

        public bool Excluir(int idSelecionado)
        {
            bool conseguiuExcluir = false;

            Registros.RemoveAt(idSelecionado);

            conseguiuExcluir = true;

            return conseguiuExcluir;
        }

        public object[] SelecionarTudo()
        {
            Registro<T>[] registrosAux = new Registro<T>[QtdCadastrados()];

            int i = 0;

            foreach (Registro<T> registro in Registros)
            {
                if (registro != null)
                    registrosAux[i++] = registro;
            }

            return registrosAux;
        }

        public object SelecionarPorId(int id)
        {
            Registro<T> registro = null;

            for (int i = 0; i < Registros.Count; i++)
            {
                if (Registros[i].Id == id)
                {
                    registro = Registros[i];

                    break;
                }
            }

            return registro;

        }

        private int QtdCadastrados()
        {
            int numero = 0;

            for (int i = 0; i < Registros.Count; i++)
            {
                if (Registros[i] != null)
                {
                    numero++;
                }
            }

            return numero;
        }

    }
}
