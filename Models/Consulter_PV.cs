using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Consulter_PV1
{
    [Key] // Indique que c'est la clé primaire
    public string Code_PV { get; set; }
    [Required]
    public string Nom_PV { get; set; }
    [Required]
    public string Nom_UE { get; set; }
    [Required]
    public string Nom_prof { get; set; }
    [Required]
    public DateTime Date_creation { get; set; }
}