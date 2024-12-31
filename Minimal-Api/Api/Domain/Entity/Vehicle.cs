using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Domain.Entity;

public class Vehicle
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; } = default!;

    [Required]
    [StringLength(150)]
    public string Nome { get;set; } = default!;

    [Required]
    [StringLength(100)]
    public string Mark { get;set; } = default!;

    [Required]
    public int Year { get;set; } = default!;
}