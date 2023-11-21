#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class ComisionesModel
    {
        [Key]
        [Column("id_comision")]
        public int IdComision { get; set; }

        [Required(ErrorMessage = "La descripción de la comisión es obligatoria.")]
        [Display(Name = "Descripción de la Comisión")]
        [Column("descripcion_comision")]
        public string DescripcionComision { get; set; }

        [Required(ErrorMessage = "El porcentaje de la comisión es obligatorio.")]
        [Display(Name = "Porcentaje de la Comisión")]
        [Range(0, 100, ErrorMessage = "El porcentaje debe estar entre 0 y 100.")]
        [Column("porcentaje_comision")]
        public decimal PorcentajeComision { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        [Required(ErrorMessage = "El Tipo de Empleado es obligatorio.")]
        [Display(Name = "Tipo de Empleado")]
        [Column("Tipo_Empleados_id_tipo_empleado")]
        public int TipoEmpleadosIdTipoEmpleado { get; set; }

        // Relación
        [ForeignKey("TipoEmpleadosIdTipoEmpleado")]
        public TipoEmpleadoModel TipoEmpleado { get; set; }
    }
}
