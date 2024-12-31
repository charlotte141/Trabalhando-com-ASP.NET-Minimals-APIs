using MinimalApi.Domain.Entity;

namespace MinimalApi.Domain.Interface;

public interface IVehicleService
{
    List<Vehicle> FindAll(int? page = 1, string? name = null, string? mark = null);
    Vehicle? FindById(int id);
    void Delete(Vehicle vehicle);
    void Update(Vehicle vehicle);
    void Clean(Vehicle vehicle);
}