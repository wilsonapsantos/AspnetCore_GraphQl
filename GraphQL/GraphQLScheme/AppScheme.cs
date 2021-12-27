using Aspncore_GraphQL.GraphQL.GraphQLQueries;
using GraphQL;
using GraphQL.Types;
namespace Aspncore_GraphQL.GraphQL.GraphQLScheme
{
    public class AppScheme : Schema
    {
        public AppScheme(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}