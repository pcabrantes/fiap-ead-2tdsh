namespace EcommerceWebApp.Models
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }

        Produto? ObterPorId(int id);
    }
}
