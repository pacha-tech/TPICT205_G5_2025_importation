using System.ComponentModel.DataAnnotations;

public class Etudiant
{
    [Key]
    [Required]
    public string Matricule { get; set; }
    [Required]
    public string Nom { get; set; }
    [Required]
    public string Prenom { get; set; }
    [Required]
    public string Date_naissance { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}