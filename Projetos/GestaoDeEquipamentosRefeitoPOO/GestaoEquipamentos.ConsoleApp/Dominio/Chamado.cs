using System;

namespace GestaoEquipamentos.ConsoleApp.Dominio
{
    public class Chamado
    {
        public int id;
        public string titulo;
        public string descricao;
        public DateTime dataAbertura;
        public Equipamento equipamento;
        public Solicitante solicitante;

        public Chamado()
        {
            id = GeradorId.GerarIdChamado();
        }
        public string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(titulo))
                resultadoValidacao += "O campo Título é obrigatório \n";

            if (string.IsNullOrEmpty(descricao))
                resultadoValidacao += "O campo Descrição é obrigatório \n";

            if (dataAbertura > DateTime.Now)
                resultadoValidacao += "O campo Data de Abertura não pode ser nmo futuro \n";

            if (string.IsNullOrEmpty(resultadoValidacao))
                resultadoValidacao = "CHAMADO_VALIDO";

            return resultadoValidacao;
        }
        public string DiasEmAberto 
        { 
            get 
            {
                TimeSpan diasEmAberto = DateTime.Now - dataAbertura;

                return diasEmAberto.ToString("dd");
            } 
        }
        
    }
}
