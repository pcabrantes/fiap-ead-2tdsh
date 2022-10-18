namespace CidadeAPI.Models
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly CidadesApiDbContext _context;

        public CidadeRepository(CidadesApiDbContext context)
        {
            _context = context;
        }

        public void Atualizar(Cidade cidade)
        {
            Cidade cidadeDB = ObterPorId(cidade.Id);
            cidadeDB.Nome = cidade.Nome;
            cidadeDB.Uf = cidade.Uf;

            _context.SaveChanges();
        }

        public void Cadastrar(Cidade cidade)
        {
            _context.Cidades.Add(cidade);

            _context.SaveChanges();
        }

        public IEnumerable<Cidade> Listar()
        {
            return _context.Cidades.OrderBy(c => c.Nome);
        }

        public Cidade? ObterPorId(long id)
        {
            return _context.Cidades.FirstOrDefault(c => c.Id == id);
        }

        public void Remover(Cidade cidade)
        {
            _context.Cidades.Remove(cidade);

            _context.SaveChanges();
        }
    }
}
