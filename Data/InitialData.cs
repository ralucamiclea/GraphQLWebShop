using GraphQLWebShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebShop.Data
{
    public static class InitialData
    {
        public static void Seed(this ApplicationDbContext dbContext)
        {
            if (!dbContext.Products.Any())
            {
                dbContext.Products.Add(new Product 
                {
                    Name = "La Sportiva Nepal Cube GTX",
                    Description = "The La Sportiva Women's Nepal Cube GTX is a warm and technical mountaineering boot.",
                    Price = 599,
                    Rating = 4,
                    Type = ProductType.footwear,
                    Stock = 12,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "Crossed the Himalayas",
                            Review = "They have absolutely no break in period."
                        },
                        new ProductReview
                        {
                            Title = "Comfortable",
                            Review = "One of the most comfortable hiking boots available."
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Salomon Quest 4D 3 GTX",
                    Description = "The Salomon Quest 4D 3 GTX Women's is all about walking comfort.",
                    Price = 229,
                    Rating = 5,
                    Type = ProductType.footwear,
                    Stock = 3,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-2),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "Very confy",
                            Review = "I'm in love with how nice my feet fit in these hiking boots."
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Osprey Men's Atmos Ag 65",
                    Description = "The Atmos AG™ 65 is the best-fitting, most ventilated and comfortable pack ever made.",
                    Price = 132,
                    Rating = 4,
                    Type = ProductType.backpack,
                    Stock = 23,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "The best backpacks outthere",
                            Review = "After buying Osprey once, you never go back."
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Osprey Manta 34",
                    Description = "Hike First Class with the Manta 34 hiking backpack.",
                    Price = 170,
                    Rating = 5,
                    Type = ProductType.backpack,
                    Stock = 6,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-5),
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview
                        {
                            Title = "Perfect for one day hikes",
                            Review = "Worth every penny. My back feels hugged when I hike with this backpack."
                        },
                        new ProductReview
                        {
                            Title = "Great backpack",
                            Review = "It's a very nice fit, but a little pricy."
                        }
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Coyote III Backpacking Tent",
                    Description = "A lightweight tunnel tent with space for three, built to withstand tough conditions.",
                    Price = 139,
                    Rating = 4,
                    Type = ProductType.tent,
                    Stock = 32,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Mountain Equipment Redline",
                    Description = "The very best 800+ fill power down and superb engineering bag.",
                    Price = 680,
                    Rating = 5,
                    Type = ProductType.sleepingbag,
                    Stock = 7,
                    PhotoFileName = "shutterstock_66842440.jpg",
                    IntroducedAt = DateTimeOffset.Now.AddMonths(-5)
                });

                dbContext.SaveChanges();
            }
        }
    }
}
