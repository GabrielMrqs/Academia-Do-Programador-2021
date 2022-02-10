using System;

namespace AgendaJP.Dominios.Model
{
    public class Compromisso : EntidadeBase
    {
        public Compromisso(string assunto, string local, DateTime inicioDoCompromisso, DateTime fimDoCompromisso, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            InicioDoCompromisso = inicioDoCompromisso;
            FimDoCompromisso = fimDoCompromisso;
            Contato = contato;
        }

        public string Assunto { get; private set; }
        public string Local { get; private set; }
        public DateTime InicioDoCompromisso { get; private set; }
        public DateTime FimDoCompromisso { get; private set; }
        public Contato Contato { get; private set; }

        public override string ToString()
        {
            return $"ID: {Id} \nAssunto: {Assunto} \nLocal: {Local} \nInício do Compromisso: {InicioDoCompromisso}" +
                $" \nFinal do Compromisso: {FimDoCompromisso} \nNome do contato: {Contato.Nome}" +
                $"\n------------------------------------------------------------------------------------------------------------------------";
        }

        public override string Validar()
        {
            string ehValido = "";
            if (string.IsNullOrEmpty(Assunto))
                ehValido += "Assunto em branco.\n";
            if (string.IsNullOrEmpty(Local))
                ehValido += "Local em branco.\n";

            return ehValido;
        }
    }
}