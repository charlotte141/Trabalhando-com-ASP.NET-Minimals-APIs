
namespace MinimalApi.Domain.DTO;
public record VehicleDTO
{
    public string Nome { get;set; } = default!;
    public string Mark { get;set; } = default!;
    public int Year { get;set; } = default!;
}