
using Aspncore_GraphQL.Contracts;
using Aspncore_GraphQL.Entities;
using Aspncore_GraphQL.Entities.Context;
namespace Aspncore_GraphQL.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> GetAll() => _context.Categorias.ToList();
    }
}