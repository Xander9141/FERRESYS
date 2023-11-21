using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("Tipo_pago_Ventas")]
    public class TipoPagoVentasModel
    {
        [Key]
        [Column("id_tipo_pago_venta")]
        public int IdTipoPagoVenta { get; set; }

        [Required(ErrorMessage = "El Tipo de Pago es obligatorio.")]
        [Display(Name = "Tipo de Pago")]
        [Column("Tipo_pago_id_tipo_pago")]
        public int TipoPagoIdTipoPago { get; set; }

        [Required(ErrorMessage = "La Venta es obligatoria.")]
        [Display(Name = "Venta")]
        [Column("Ventas_id_venta")]
        public int VentasIdVenta { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        // Relaciones
        [ForeignKey("TipoPagoIdTipoPago")]
        public TipoPagoModel TipoPago { get; set; }

        [ForeignKey("VentasIdVenta")]
        public VentaModel Venta { get; set; }
    }
}
