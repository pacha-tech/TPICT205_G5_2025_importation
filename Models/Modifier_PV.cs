using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Modifier_PV1
{

    [Key] // Indique que c'est la clé primaire
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    //[Required(ErrorMessage = "Le Code du PV est requis.")]  Indique que c'est la clé primaire
    [ForeignKey("Creation_PV1")]
    public string CODE_PV { get; set; }
    
    public string Nom_PV { get; set; }
    
    public string Nom_UE { get; set; }
    
    public string Nom_prof { get; set; }
    
    
    public virtual Creation_PV1 PV { get; set; } // Propriété de navigation
}