using Microsoft.AspNetCore.Mvc;
using EcommerceWebApp.Models;
using EcommerceWebApp.ViewModels;

namespace EcommerceWebApp.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Listar()
        {
            ListaProdutosViewModel viewModel = new ListaProdutosViewModel(_produtoRepository.Produtos, "Bebidas");            
            return View(viewModel);
        }
    }
}
