using MongoRepo.Context;

namespace CategoryAPI.DbContext
{
    public class CategoryDbContext:ApplicationDbContext
    {
        static string ConnectionString=new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",true,true).Build().GetConnectionString("Category.API")
        public CategoryDbContext(string connectionString,string databaseName) : base(connectionString,databaseName){

        }
    }
}
