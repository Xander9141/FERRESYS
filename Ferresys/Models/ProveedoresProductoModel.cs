#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class ProveedoresProductosModel
    {
        [Key]
        [Column("id_proveedor_producto")]
        public int IdProveedorProducto { get; set; }

        [Required(ErrorMessage = "El Proveedor es obligatorio.")]
        [Display(Name = "Proveedor")]
        [Column("Proveedores_id_proveedor")]
        public int ProveedoresIdProveedor { get; set; }

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
        [ForeignKey("ProveedoresIdProveedor")]
        public ProveedorModel Proveedor { get; set; }

        [ForeignKey("ProductosIdProducto")]
        public ProductoModel Producto { get; set; }
    }
}
