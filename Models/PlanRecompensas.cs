using System.ComponentModel.DataAnnotations;

namespace GalindoFP1.Models;

public class PlanRecompensas
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del plan es obligatorio.")]
    [Display(Name = "Nombre del Plan")]
    public string Nombre { get; set; }

    [Display(Name = "Fecha de Inicio")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El formato de fecha debe ser AAAA-MM-DD.")]
    public string FechaInicio { get; set; }

    [Display(Name = "Puntos Acumulados")]
    public int PuntosAcumulados { get; set; }

    [Display(Name = "Tipo de Recompensa")]
    public string TipoRecompensa
    {
        get
        {
            return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
        }
    }

}