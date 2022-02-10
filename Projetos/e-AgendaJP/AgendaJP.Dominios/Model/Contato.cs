using System;
using System.Net.Mail;

namespace AgendaJP.Dominios.Model
{
    public class Contato : EntidadeBase
    {
        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public string Nome { get; set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Empresa { get; private set; }
        public string Cargo { get; private set; }
        public override string ToString()
        {
            return $"ID: {Id} | {Nome}";
        }

        public override string Validar()
        {
            string ehValido = "";

            if (string.IsNullOrEmpty(Nome))
                ehValido += "Nome em branco.\n";
            if (string.IsNullOrEmpty(Cargo))
                ehValido += "Cargo em branco.\n";
            if (string.IsNullOrEmpty(Empresa))
                ehValido += "Empresa em branco.\n";
            if (string.IsNullOrEmpty(Telefone) || Telefone.Length != 14)
                ehValido += "Telefone em formato inválido.\n";
            if (string.IsNullOrEmpty(Email))
                return ehValido += "E-mail em branco.\n";
            try
            {
                MailAddress m = new MailAddress(Email);
            }
            catch (FormatException)
            {
                ehValido += "E-mail em formato inválido.\n";
            }

            return ehValido;
        }
    }
}
