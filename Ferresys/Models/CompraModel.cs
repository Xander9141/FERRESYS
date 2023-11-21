using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class CompraModel
    {
        [Key]
        [Column("id_compra")]
        public int IdCompra { get; set; }

        [Required(ErrorMessage = "La fecha de compra es obligatoria.")]
        [Display(Name = "Fecha de Compra")]
        [Column("fecha_compra")]
        public DateTime FechaCompra { get; set; }

        [Required(ErrorMessage = "La cantidad de compra es obligatoria.")]
        [Display(Name = "Cantidad de Compra")]
        [Column("cantidad_compra")]
        public int CantidadCompra { get; set; }

        [Required(ErrorMessage = "El monto neto es obligatorio.")]
        [Display(Name = "Monto Neto")]
        [Column("monto_neto")]
        public int MontoNeto { get; set; }

        [Required(ErrorMessage = "La fecha de actualización es obligatoria.")]
        [Display(Name = "Fecha de Actualización")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        [Required(ErrorMessage = "El monto total de compra es obligatorio.")]
        [Display(Name = "Monto Total de Compra")]
        [Column("monto_total_compra")]
        public int MontoTotalCompra { get; set; }

        [Required(ErrorMessage = "El proveedor es obligatorio.")]
        [Display(Name = "Proveedor")]
        [Column("Proveedores_id_proveedor")]
        public int ProveedoresIdProveedor { get; set; }

        // Relación con la tabla de proveedores
        [ForeignKey("ProveedoresIdProveedor")]
        public ProveedorModel Proveedor { get; set; }
    }
}
