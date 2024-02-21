using Microsoft.EntityFrameworkCore;
namespace SchoolDemo.DataBase;
public class LoginDbContext : DbContext
{
    public virtual DbSet<LoginRequest> Login { get; set; }
    public LoginDbContext(DbContextOptions<LoginDbContext> options)
        : base(options)
    {
    }
}
