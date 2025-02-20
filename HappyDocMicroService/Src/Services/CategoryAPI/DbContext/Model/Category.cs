using MongoDB.Bson.Serialization.Attributes;

namespace CategoryAPI.DbContext.Model
{
    public class Category
    {
        [BsonId]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
