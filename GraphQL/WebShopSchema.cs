using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
