using System.ComponentModel.DataAnnotations;

public class Supprimer_PV1
{
    [Required(ErrorMessage = "Le code du PV est requis.")]
    [StringLength(50, ErrorMessage = "Le code du PV ne peut pas d�passer 50 caract�res.")]
    public string Code_PV { get; set; }
}