using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RibahFlix.Models;
// Declarar nome do banco
[Table("Genre")]
public class Genre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public sbyte Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage ="Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30  caracteres")]
    public string Name { get; set; }

    public ICollection<MovieGenre> Movies { get; set; }
}