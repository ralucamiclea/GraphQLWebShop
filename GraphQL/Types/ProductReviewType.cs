using GraphQL.Types;
using GraphQLWebShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebShop.GraphQL.Types
{
    public class ProductReviewType : ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(r => r.Id);
            Field(r => r.Title).Description("Title of the reviw.");
            Field(r => r.Review).Description("Content of the review.");
            Field(r => r.ProductId).Description("The Id of the product that was reviewd.");
        }
    }
}
