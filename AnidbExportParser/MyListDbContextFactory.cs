using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AnidbExportParser
{
    public class MyListDbContextFactory
    {
        public DbContextOptions<MyListDbContext> ContextOptions { get; private set; }
        public string DBFilePath { get; }

        public MyListDbContextFactory(DbContextOptions<MyListDbContext> contextOptions)
        {
            this.ContextOptions = contextOptions;
        }
        public MyListDbContextFactory(string path)
        {
            DBFilePath = path;
            ContextOptions = new DbContextOptionsBuilder<MyListDbContext>()
                .UseSqlite("Data Source=" + this.DBFilePath)
                .Options;
        }

        /// <summary>Makes sure that the Database is created and migrations are applied.</summary>  
        public void MigrateDB()
        {
            using var context = new MyListDbContext(ContextOptions);
            context.Database.Migrate();
        }

        public MyListDbContext GetContext()
        {
            return new MyListDbContext(ContextOptions);
        }
    }
}
