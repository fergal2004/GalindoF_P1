using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalindoFP1.Models;

public class Reserva
{
    [Key]
    public int Id { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Entrada")]
    public DateTime FechaEntrada { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Salida")]
    public DateTime FechaSalida { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "El valor a pagar debe ser mayor que 0.")]
    [Display(Name = "Valor a Pagar")]
    public decimal ValorAPagar { get; set; }

    [Display(Name = "Cliente")]
    public int ClienteId { get; set; } // llave foranea
    [ForeignKey("ClienteId")]
    
    public Cliente? Cliente { get; set; } 
}