
using Microsoft.EntityFrameworkCore;

namespace Tiendita_suprema.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
