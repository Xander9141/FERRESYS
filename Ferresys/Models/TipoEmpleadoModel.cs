using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("Tipo_Empleados")]
    public class TipoEmpleadoModel
    {
        [Key]
        [Column("id_tipo_empleado")]
        public int IdTipoEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Descripción del Tipo es obligatorio.")]
        [Display(Name = "Descripción del Tipo")]
        [Column("descripcion_tipo")]
        public string DescripcionTipo { get; set; }
    }
}
