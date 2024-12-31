using MinimalApi.Domain.Enum;

namespace MinimalApi.DOmain.DTO;
public class AdministratorDTO
{
    public string Email { get;set; } = default!;
    public string PassWord { get;set; } = default!;
    public Perfil? Perfil { get;set; } = default!;
}