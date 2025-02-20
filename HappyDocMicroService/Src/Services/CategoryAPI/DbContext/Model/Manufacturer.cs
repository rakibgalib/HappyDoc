using MongoDB.Bson.Serialization.Attributes;

namespace CategoryAPI.DbContext.Model
{
    public class Manufacturer
    {
        [BsonId]

        public int ManufacturerId { get; set; }

        public string ManufacturerName { get; set; }
    }
}
