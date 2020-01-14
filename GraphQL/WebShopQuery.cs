using GraphQL.Types;
using GraphQLWebShop.GraphQL.Types;
using GraphQLWebShop.Repositories;

namespace GraphQLWebShop.GraphQL
{
    public class WebShopQuery: ObjectGraphType
    {
        public WebShopQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
               "products",
               resolve: context => productRepository.GetAll()
            );
        }
                
    }
}
