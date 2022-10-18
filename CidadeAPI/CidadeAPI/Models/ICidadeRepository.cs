namespace CidadeAPI.Models
{
    public interface ICidadeRepository
    {
        public Cidade? ObterPorId(long id);
        public IEnumerable<Cidade> Listar();
        public void Cadastrar(Cidade cidade);
        public void Atualizar(Cidade cidade);
        public void Remover(Cidade cidade);
    }
}
