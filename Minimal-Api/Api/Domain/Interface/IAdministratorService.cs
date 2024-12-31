using MinimalApi.Domain.Entity;
using MinimalApi.Domain.DTO;

namespace MinimalApi.Dominio.Interface;

public interface IAdministratorService
{
    Administrator? Login(LoginDTO loginDTO);
    Administrator Delete(Administrator administrator);
    Administrator? FindById(int id);
    List<Administrator> FindAll(int? page);
}