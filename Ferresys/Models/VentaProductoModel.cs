using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class VentasProductosModel
    {
        [Key]
        [Column("id_venta_producto")]
        public int IdVentaProducto { get; set; }

        [Required(ErrorMessage = "La Venta es obligatoria.")]
        [Display(Name = "Venta")]
        [Column("Ventas_id_venta")]
        public int VentasIdVenta { get; set; }

        [Required(ErrorMessage = "El Producto es obligatorio.")]
        [Display(Name = "Producto")]
        [Column("Productos_id_producto")]
        public int ProductosIdProducto { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        // Relaciones
        [ForeignKey("VentasIdVenta")]
        public VentaModel Venta { get; set; }

        [ForeignKey("ProductosIdProducto")]
        public ProductoModel Producto { get; set; }
    }
}
