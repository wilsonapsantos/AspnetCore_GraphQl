using Aspncore_GraphQL.Entities;
using GraphQL.Types;
namespace Aspncore_GraphQL.GraphQL.GraphQLTypes
{
    public class ProdutoType : ObjectGraphType<Produto>
    {
        public ProdutoType()
        {
            Field(x => x.ProdutoId, type: typeof(IdGraphType))
                .Description("Propriedade ProdutoId do objeto produto.");
            Field(x => x.Nome)
                .Description("Propriedade Nome do objeto produto.");
            Field(x => x.ImagemUrl)
                .Description("Propriedade ImagemUrl do objeto produto.");
        }
    }
}