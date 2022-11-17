using Lab10.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab10.Repository;

public class ApplicationContext: DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) 
    {
        
    }
    public DbSet<Book> Books { get; set; }
}