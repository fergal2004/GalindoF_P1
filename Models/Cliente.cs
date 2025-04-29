using System.ComponentModel.DataAnnotations;

namespace GalindoFP1.Models
{
    public class Cliente
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres.")]
        [Display(Name = "Nombre del Cliente")]
        public string Nombre { get; set; } //Ej: CordovaS

        [Range(1, 150, ErrorMessage = "La edad debe ser entre 1 y 100.")]
        public int Edad { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El saldo debe ser mayor que 0")]
        public decimal Saldo { get; set; }

        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get; set; }

        public bool EsActivo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
    }
}