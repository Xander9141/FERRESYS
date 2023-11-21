#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class ProductoModel
    {
        [Key]
        [Column("id_producto")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El campo Nombre de Producto es obligatorio.")]
        [Column("nombre_producto")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "El campo Descripción de Producto es obligatorio.")]
        [Column("descripcion_producto")]
        public string DescripcionProducto { get; set; }

        [Required(ErrorMessage = "El campo Valor de Compra es obligatorio.")]
        [Column("valor_compra")]
        public int ValorCompra { get; set; }

        [Required(ErrorMessage = "El campo Valor de Venta es obligatorio.")]
        [Column("valor_venta")]
        public int ValorVenta { get; set; }

        public DateTime fecha_creacion { get; set; } = DateTime.Now;

        public DateTime fecha_actualizacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Bodega es obligatorio.")]
        [ForeignKey("Bodegas_id_bodega")]
        public int BodegasIdBodega { get; set; }

        // Relación con la Bodega
        public BodegaModel Bodega { get; set; }
    }
}
