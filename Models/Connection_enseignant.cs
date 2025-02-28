using System.ComponentModel.DataAnnotations;

public class Enseignant_connection
{
    [Required(ErrorMessage = "L'Email est requis.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Le mot de passe est requis.")]
    public string Password { get; set; }
}