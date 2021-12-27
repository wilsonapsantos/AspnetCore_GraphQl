using Aspncore_GraphQL.Entities;
using GraphQL.Types;
namespace Aspncore_GraphQL.GraphQL.GraphQLTypes
{
    public class CategoriaType : ObjectGraphType<Categoria>
    {
        public CategoriaType()
        {
            Field(x => x.CategoriaId, type: typeof(IdGraphType))
                .Description("Propriedade CategoriaId do objeto categoria.");
            Field(x => x.Nome)
                .Description("Propriedade Nome do objeto categoria.");
            Field(x => x.ImagemUrl)
                .Description("Propriedade ImagemUrl do objeto categoria.");
        }
    }
}