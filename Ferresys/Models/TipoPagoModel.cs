using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class TipoPagoModel
    {
        [Key]
        public int IdTipoPago { get; set; }

        [Required(ErrorMessage = "La descripción del tipo de pago es obligatoria.")]
        [Display(Name = "Descripción del Tipo de Pago")]
        public string DescripcionTipoPago { get; set; }
    }
}
