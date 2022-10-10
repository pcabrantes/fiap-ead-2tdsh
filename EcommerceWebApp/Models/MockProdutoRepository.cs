namespace EcommerceWebApp.Models
{
    public class MockProdutoRepository : IProdutoRepository
    {
        private readonly ICategoriaRepository _categoriaRepository = new MockCategoriaRepository();

        public IEnumerable<Produto> Produtos =>
            new List<Produto>()
            {
                new Produto
                {
                    Id = 1, Nome = "Refrigerante", Descricao = "Um refrigerante qualquer",
                    UrlImagem = "https://s2.glbimg.com/GUda5oj9xkd_yQNyn36mDn9XJmo=/620x455/e.glbimg.com/og/ed/f/original/2018/08/17/beber-refrigerante-todos-os-dias-esta-te-matando.jpg",
                    Preco = 10, Disponivel = true, Categoria = _categoriaRepository.ObterPorId(1)
                },
                new Produto
                {
                    Id = 2, Nome = "Cerveja", Descricao = "Uma cerveja qualquer",
                    UrlImagem = "https://img.imageboss.me/consul/cdn/animation:true/wp-content/uploads/2021/03/imagem_feed_02-10.png",
                    Preco = 15, Disponivel = true, Categoria = _categoriaRepository.ObterPorId(1)
                },
                new Produto
                {
                    Id = 3, Nome = "Arroz", Descricao = "Arroz Branco",
                    UrlImagem = "https://melhorcomsaude.com.br/wp-content/uploads/2014/12/Grandes_beneficios_%C3%A1gua_de_arroz-500x333.jpg",
                    Preco = 8.5,Disponivel = true, Categoria = _categoriaRepository.ObterPorId(2)
                }
            };

        public Produto? ObterPorId(int id) => Produtos.FirstOrDefault(o => o.Id == id);
    }
}
