using Microsoft.EntityFrameworkCore;
using MinimalApi.Domain.Entity;

namespace MinimalApi.Infrastructure.Db;

public class Context : DbContext
{
    private readonly IConfiguration configuracaoAppSettings;
    public Context(IConfiguration _configuracaoAppSettings, DbContextOptions<Context> options): base(options){

        configuracaoAppSettings = _configuracaoAppSettings;

    }

    public DbSet<Administrator> Administradores { get; set; } = default!;
    public DbSet<Vehicle> Veiculos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>().HasData(
            new Administrator {
                Id = 1,
                Email = "administrador@teste.com",
                PassWord = "123456",
                Perfil = "Adm"
             }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var stringConexao = configuracaoAppSettings.GetConnectionString("SQLServer")?.ToString();
            if(!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseSqlServer(
                    stringConexao
                );
            }
        }
    }
}