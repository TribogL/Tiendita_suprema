
using Microsoft.EntityFrameworkCore;
using Tiendita_suprema.Models;

namespace Tiendita_suprema.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
