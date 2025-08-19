namespace BibliotecaApi.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public required string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
    }
}