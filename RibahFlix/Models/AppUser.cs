using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RibahFlix.Models;
// Declarar nome do banco
[Table("AppUser")]
public class AppUser
{
    [Key]
    public string AppUserId { get; set; }
    [ForeignKey("AppUserId")]

    public IdentityUser UserAccount { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage ="Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60  caracteres")]
    public string Name { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por Favor, informe a Data de Nascimento ")]
    public DateTime Birthday { get; set; }

    [StringLength(300)]
    [Display(Name = "Avatar")]
    public string Photo { get; set; }
}