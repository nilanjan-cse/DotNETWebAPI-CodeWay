using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebAPI_CodeWay.Models
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> dbContextOptions) : base(dbContextOptions)
        {

            try
            {
                var DatabaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (DatabaseCreator != null)
                {
                    if (!DatabaseCreator.CanConnect())
                    {
                        DatabaseCreator.Create();
                    }
                    if (!DatabaseCreator.HasTables())
                    {
                        DatabaseCreator.CreateTables();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public DbSet<UserInfo> UsersDB { get; set; }
        // added this code to child-branch
    }
}
