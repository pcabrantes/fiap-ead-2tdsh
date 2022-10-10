namespace EcommerceWebApp.Models
{
    public class MockCategoriaRepository : ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias =>
            new List<Categoria>() {
                new Categoria { Id = 1, Nome = "Bebidas", Descricao = "Todas as bebidas" },
                new Categoria { Id = 2, Nome = "Comidas", Descricao = "Todas as comidas" }
            };

        public Categoria? ObterPorId(int id)
        {
            return Categorias.FirstOrDefault(c => c.Id == id);
        }
    }
}
