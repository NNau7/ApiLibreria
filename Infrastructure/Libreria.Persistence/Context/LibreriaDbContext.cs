using Libreria.Domain;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Persistence.Context;

public class LibreriaDbContext : DbContext
{
    public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Member> Members { get; set; }
}