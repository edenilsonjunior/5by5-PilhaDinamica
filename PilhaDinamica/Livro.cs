namespace PilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            anterior = null;
        }

        public override string? ToString()
        {
            return $"Livro: {titulo}";
        }

        public void SetAnterior(Livro livro)
        {
            this.anterior = livro;
        }

        public Livro GetAnterior()
        {
            return anterior;
        }

        public string GetTitulo()
        {
            return titulo;
        }
    }
}
