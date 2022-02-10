using AgendaJP.Dominios.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace AgendaJP.Controladores.Model
{
    public class ControladorContato : Controlador<Contato>
    {
        #region Queries
        public override string SqlSelecaoTodos => $@"SELECT * FROM TBCONTATO ORDER BY CARGO";
        public override string Tabela => "TBCONTATO";
        public override string Valores => "[NOME],[EMAIL],[TELEFONE],[EMPRESA],[CARGO]";
        public override string Atualizar => "[NOME] = @NOME,[EMAIL] = @EMAIL,[TELEFONE] = @TELEFONE,[EMPRESA] = @EMPRESA,[CARGO] = @CARGO";
        #endregion
        public override void InserirNoBanco(dynamic comandoInsercao, Contato contato)
        {
            comandoInsercao.Parameters.AddWithValue("NOME", contato.Nome);
            comandoInsercao.Parameters.AddWithValue("EMAIL", contato.Email);
            comandoInsercao.Parameters.AddWithValue("TELEFONE", contato.Telefone);
            comandoInsercao.Parameters.AddWithValue("EMPRESA", contato.Empresa);
            comandoInsercao.Parameters.AddWithValue("CARGO", contato.Cargo);
        }
        public override void EditarNoBanco(dynamic comandoEdicao, int id, Contato contato)
        {
            comandoEdicao.Parameters.AddWithValue("ID", id);
            comandoEdicao.Parameters.AddWithValue("NOME", contato.Nome);
            comandoEdicao.Parameters.AddWithValue("EMAIL", contato.Email);
            comandoEdicao.Parameters.AddWithValue("TELEFONE", contato.Telefone);
            comandoEdicao.Parameters.AddWithValue("EMPRESA", contato.Empresa);
            comandoEdicao.Parameters.AddWithValue("CARGO", contato.Cargo);
        }
        public override void LerRegistros(dynamic leitorTarefas, List<Contato> registros)
        {
            while (leitorTarefas.Read())
            {
                int id = Convert.ToInt32(leitorTarefas["ID"]);
                string nome = Convert.ToString(leitorTarefas["NOME"]);
                string email = Convert.ToString(leitorTarefas["EMAIL"]);
                string telefone = Convert.ToString(leitorTarefas["TELEFONE"]);
                string empresa = Convert.ToString(leitorTarefas["EMPRESA"]);
                string cargo = Convert.ToString(leitorTarefas["CARGO"]);

                Contato registro = new Contato(nome, email, telefone, empresa, cargo);
                registro.Id = id;

                registros.Add(registro);
            }

        }
    }
}