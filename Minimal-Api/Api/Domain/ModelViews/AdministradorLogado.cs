using MinimalApi.Domain.Enum;

namespace MinimalApi.Domain.ModelViews;

public record AdministratorLoginOn
{
    public string Email { get;set; } = default!;
    public string Perfil { get;set; } = default!;
    public string Token { get;set; } = default!;
}