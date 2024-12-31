using MinimalApi.Domain.Entity;
using MinimalApi.Domain.DTO;
using MinimalApi.Infrastructure.Db;
using MinimalApi.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Dominio.Servicos;

public class VehicleService
{
    private readonly Context _context;
    public VehicleService(Context context)
    {
        _context = context;
    }

    public void Apagar(Vehicle vehicle)
    {
        _context.Veiculos.Remove(vehicle);
        _context.SaveChanges();
    }

    public void Atualizar(Vehicle vehicle)
    {
        _context.Veiculos.Update(vehicle);
        _context.SaveChanges();
    }

    public Vehicle? BuscaPorId(int id)
    {
        return _context.Veiculos.Where(v => v.Id == id).FirstOrDefault();
    }

    public void Incluir(Vehicle vehicle)
    {
        _context.Veiculos.Add(vehicle);
        _context.SaveChanges();
    }

    public List<Vehicle> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        var query = _context.Veiculos.AsQueryable();
        if(!string.IsNullOrEmpty(nome))
        {
            query = query.Where(v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome}%"));
        }

        int itensPorPagina = 10;

        if(pagina != null)
            query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);

        return query.ToList();
    }
}