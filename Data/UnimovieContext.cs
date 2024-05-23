using Microsoft.EntityFrameworkCore;
using UniMovie.Models;

namespace UniMovie.Data;

public class UnimovieContext : DbContext
{
    public UnimovieContext(DbContextOptions<UnimovieContext> options)
     : base(options)
     {        
     }

    public DbSet<Filme> Filmes {get; set;} = null!;
}