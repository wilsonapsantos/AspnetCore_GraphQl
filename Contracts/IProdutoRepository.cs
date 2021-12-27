using Aspncore_GraphQL.Entities;

namespace Aspncore_GraphQL.Contracts
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
    }
}