namespace EcommerceWebApp.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UrlImagem { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }
        public Categoria Categoria { get; set; }
    }
}
