#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class DescuentosModel
    {
        [Key]
        public int IdDescuento { get; set; }

        [Required(ErrorMessage = "La descripción del descuento es obligatoria.")]
        [Display(Name = "Descripción del Descuento")]
        public string DescripcionDescuento { get; set; }

        [Required(ErrorMessage = "El porcentaje del descuento es obligatorio.")]
        [Display(Name = "Porcentaje del Descuento")]
        [Range(0, 100, ErrorMessage = "El porcentaje debe estar entre 0 y 100.")]
        public decimal PorcentajeDescuento { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime FechaCreacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime FechaActualizacion { get; set; }

        [Required(ErrorMessage = "El Tipo de Cliente es obligatorio.")]
        [Display(Name = "Tipo de Cliente")]
        public int TipoClienteIdCliente { get; set; }
    }
}
