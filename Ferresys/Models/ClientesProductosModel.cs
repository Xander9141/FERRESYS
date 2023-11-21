#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("Clientes_Productos")]
    public class ClientesProductosModel
    {
        [Key]
        [Column("id_cliente_producto")]
        public int IdClienteProducto { get; set; }

        [Required(ErrorMessage = "El Producto es obligatorio.")]
        [Display(Name = "Producto")]
        [Column("Productos_id_producto")]
        public int ProductosIdProducto { get; set; }

        [Required(ErrorMessage = "El Cliente es obligatorio.")]
        [Display(Name = "Cliente")]
        [Column("Clientes_id_cliente")]
        public int ClientesIdCliente { get; set; }

        [Required(ErrorMessage = "La cantidad de productos es obligatoria.")]
        [Display(Name = "Cantidad de Productos")]
        [Column("cantidad_producto")]
        public int CantidadProducto { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("ProductosIdProducto")]
        public ProductoModel Producto { get; set; }

        [ForeignKey("ClientesIdCliente")]
        public ClienteModel Cliente { get; set; }
    }
}

