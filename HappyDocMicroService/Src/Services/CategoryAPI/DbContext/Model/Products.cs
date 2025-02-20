﻿using MongoDB.Bson.Serialization.Attributes;

namespace CategoryAPI.DbContext.Model
{
    public class Products
    {
        [BsonId]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Summery { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
