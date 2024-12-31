using MinimalApi.Domain.Enum;

namespace MinimalApi.Domain.ModelViews;

public record AdministratorModelView
{
    public int Id { get;set; } = default!;
    public string Email { get;set; } = default!;
    public string Perfil { get;set; } = default!;
}