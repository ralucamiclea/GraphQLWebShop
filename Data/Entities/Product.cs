﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public string Description { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset IntroducedAt { get; set; }


        [StringLength(100)]
        public string PhotoFileName { get; set; }
    }
}
