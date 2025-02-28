using System.ComponentModel.DataAnnotations;

public class Etudiant_connection
{
    [Required(ErrorMessage = "Le matricule est requis.")]
    public string Matricule { get; set; }

    [Required(ErrorMessage = "Le mot de passe est requis.")]
    public string Password { get; set; }
}