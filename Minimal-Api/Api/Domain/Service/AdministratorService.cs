using MinimalApi.Domain.Entity;
using MinimalApi.Domain.DTO;
using MinimalApi.Infrastructure.Db;
using MinimalApi.Domain.Interface;

namespace MinimalApi.Dominio.Servicos;

public class AdministratorService
{
    private readonly Context _context;
    public AdministratorService(Context context)
    {
        _context = context;
    }

    public Administrator? BuscaPorId(int id)
    {
        return _context.Administradores.Where(v => v.Id == id).FirstOrDefault();
    }

    public Administrator Incluir(Administrator administrator)
    {
        _context.Administradores.Add(administrator);
        _context.SaveChanges();

        return administrator;
    }

    public Administrator? Login(LoginDTO loginDTO)
    {
        var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.PassWord == loginDTO.PassWord).FirstOrDefault();
        return adm;
    }

    public List<Administrator> Todos(int? pagina)
    {
        var query = _context.Administradores.AsQueryable();

        int itensPorPagina = 10;

        if(pagina != null)
            query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);

        return query.ToList();
    }
}