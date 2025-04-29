using System.ComponentModel.DataAnnotations;

namespace GalindoFP1.Models;

public class PlanRecompensas
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del plan es obligatorio.")]
    [Display(Name = "Nombre del Plan")]
    public string Nombre { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Inicio")]
    public DateTime FechaInicio { get; set; }

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