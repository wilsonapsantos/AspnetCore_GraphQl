using Aspncore_GraphQL.Entities;
namespace Aspncore_GraphQL.Contracts
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
    }
}