using GraphQL;
using GraphQL.Types;

namespace GraphQLWebShop.GraphQL
{
    public class WebShopSchema: Schema
    {
        public WebShopSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<WebShopQuery>();
        }
    }
}
