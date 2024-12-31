using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MinimalApi.Infrastructure.Db.Context>(options =>
            options.UseSqlServer("Server=localhost\\sqlexpress; Initial Catalog=Administrator; Integrated security=True; TrustServerCertificate=True; Encrypt=False")
        );

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
