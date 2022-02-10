using System;

namespace ClubeDaLeitura.ConsoleApp.Telas
{
    public abstract class TelaBase
    {
        public abstract void Registrar(int id);

        public abstract void Visualizar();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract string ObterOpcao();

        public virtual void Menu()
        {
            Console.Clear();

            string opcao = ObterOpcao();

            if (opcao == "1")
                Registrar(0);

            if (opcao == "2")
                Visualizar();

            if (opcao == "3")
                Editar();

            if (opcao == "4")
                Excluir();

            if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))

            Console.Clear();
        }
    }
}
