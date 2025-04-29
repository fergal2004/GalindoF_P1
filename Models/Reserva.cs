using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalindoFP1.Models;

public class Reserva
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Fecha de Entrada")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El formato de fecha debe ser AAAA-MM-DD.")]
    public string FechaEntrada { get; set; }

    [Display(Name = "Fecha de Salida")]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "El formato de fecha debe ser AAAA-MM-DD.")]
    public string FechaSalida { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "El valor a pagar debe ser mayor que 0.")]
    [Display(Name = "Valor a Pagar")]
    public decimal ValorAPagar { get; set; }

    [Display(Name = "Cliente")]
    public int ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public Cliente? Cliente { get; set; }

}