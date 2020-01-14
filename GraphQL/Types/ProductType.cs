using GraphQL.Types;
using GraphQLWebShop.Data.Entities;

namespace GraphQLWebShop.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
        }
    }
}
