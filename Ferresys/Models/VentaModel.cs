#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class VentaModel
    {
        [Key]
        [Column("id_venta")]
        public int IdVenta { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Venta es obligatorio.")]
        [Display(Name = "Fecha de Venta")]
        [Column("fecha_venta")]
        public DateTime FechaVenta { get; set; }

        [Required(ErrorMessage = "El campo Cantidad de Venta es obligatorio.")]
        [Display(Name = "Cantidad de Venta")]
        [Column("cantidad_venta")]
        public int CantidadVenta { get; set; }

        [Display(Name = "Fecha de Actualización")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        [Required(ErrorMessage = "El campo Monto Neto es obligatorio.")]
        [Display(Name = "Monto Neto")]
        [Column("monto_neto")]
        public int MontoNeto { get; set; }

        [Required(ErrorMessage = "El campo Monto Total de Venta es obligatorio.")]
        [Display(Name = "Monto Total de Venta")]
        [Column("monto_total_venta")]
        public int MontoTotalVenta { get; set; }

        [Required(ErrorMessage = "El campo ID de Empleado es obligatorio.")]
        [Display(Name = "ID de Empleado")]
        [Column("Empleados_id_empleado")]
        public int EmpleadosIdEmpleado { get; set; }

        [Required(ErrorMessage = "El campo ID de Cliente es obligatorio.")]
        [Display(Name = "ID de Cliente")]
        [Column("id_cliente")]
        public int IdCliente { get; set; }

        // Relaciones
        public EmpleadoModel Empleado { get; set; }

        public ClienteModel Cliente { get; set; }
    }
}
