namespace EcommerceWebApp.Models
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }

        Categoria? ObterPorId(int id);
    }
}
