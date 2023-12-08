using MaterialDeContrucaoAppWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaterialDeContrucaoAppWeb.Data;

public class MatConstDBContext : IdentityDbContext
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string myConn = config.GetConnectionString("MyConn");

        optionsBuilder.UseSqlServer(myConn);
    }
}

