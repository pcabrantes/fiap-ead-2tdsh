using EcommerceWebApp.Models;

namespace EcommerceWebApp.ViewModels
{
    public class ListaProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; }
        public string? CategoriaSelecionada { get; }

        public ListaProdutosViewModel(IEnumerable<Produto> produtos, string? categoriaSelecionada)
        {
            Produtos = produtos;
            CategoriaSelecionada = categoriaSelecionada;
        }
    }
}
