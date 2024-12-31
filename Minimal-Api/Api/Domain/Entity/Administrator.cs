using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Domain.Entity;

public class Administrator
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; } = default!;

    [Required]
    [StringLength(255)]
    public string Email { get;set; } = default!;

    [Required]
    [StringLength(50)]
    public string PassWord { get;set; } = default!;

    [Required]
    [StringLength(10)]
    public string Perfil { get;set; } = default!;
}