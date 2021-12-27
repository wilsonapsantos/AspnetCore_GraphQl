using Aspncore_GraphQL.Contracts;
using Aspncore_GraphQL.GraphQL.GraphQLTypes;
using GraphQL.Types;
namespace Aspncore_GraphQL.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ICategoriaRepository categoriaRepo, IProdutoRepository produtoRepo)
        {
            Field<ListGraphType<CategoriaType>>(
               "categorias",
               resolve: context => categoriaRepo.GetAll()
           );

           Field<ListGraphType<ProdutoType>>(
               "produtos",
               resolve: context => produtoRepo.GetAll()
           );
        }
    }
}