using MongoRepo.Context;

namespace CategoryAPI.DbContext
{
    public class CategoryDbContext:ApplicationDbContext
    {
        public CategoryDbContext(string connectionString,string databaseName) : base(connectionString,databaseName){

        }
    }
}
