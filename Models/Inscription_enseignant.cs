using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Enseignant
{
    [Key] // Indique que c'est la clé primaire
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
    [Required]
    public string Nom { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}