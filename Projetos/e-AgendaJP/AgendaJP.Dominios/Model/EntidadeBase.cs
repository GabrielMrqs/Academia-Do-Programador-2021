namespace AgendaJP.Dominios.Model
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public abstract string Validar();
    }
}

