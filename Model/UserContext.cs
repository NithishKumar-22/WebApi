using Microsoft.EntityFrameworkCore;
#nullable disable
namespace Admin.Models;

public class UserContext : DbContext
{
    public UserContext (DbContextOptions<UserContext> options) : base(options)
        {
            
        }

    public DbSet<User> UserLogins{get;set;}

}