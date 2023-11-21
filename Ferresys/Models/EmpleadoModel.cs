#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class EmpleadoModel
    {
        [Key]
        [Column("id_empleado")]
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Rut es obligatorio.")]
        [Column("rut_empleado")]
        public string RutEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [Column("nombre_empleado")]
        public string NombreEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio.")]
        [Column("apellido_paterno_empleado")]
        public string ApellidoPaternoEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Apellido Materno es obligatorio.")]
        [Column("apellido_materno_empleado")]
        public string ApellidoMaternoEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Dirección es obligatorio.")]
        [Column("direccion_empleado")]
        public string DireccionEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        [Column("telefono_empleado")]
        public string TelefonoEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo electrónico válida.")]
        [Column("email_empleado")]
        public string EmailEmpleado { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion_empleado")]
        public DateTime FechaCreacionEmpleado { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion_empleado")]
        public DateTime FechaActualizacionEmpleado { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Usuario es obligatorio.")]
        [ForeignKey("Usuarios_id_usuario")]
        public int UsuariosIdUsuario { get; set; }

        [Required(ErrorMessage = "El campo Tipo de Empleado es obligatorio.")]
        [ForeignKey("Tipo_Empleados_id_tipo_empleado")]
        public int TipoEmpleadosIdTipoEmpleado { get; set; }

        [Required(ErrorMessage = "El campo Región es obligatorio.")]
        [ForeignKey("Regiones_id_region")]
        public int RegionesIdRegion { get; set; }

        [Required(ErrorMessage = "El campo Ciudad es obligatorio.")]
        [ForeignKey("Ciudades_id_ciudad")]
        public int CiudadesIdCiudad { get; set; }

        [Required(ErrorMessage = "El campo Comuna es obligatorio.")]
        [ForeignKey("Comunas_id_comuna")]
        public int ComunasIdComuna { get; set; }

        [Required(ErrorMessage = "El campo Sueldo es obligatorio.")]
        [Column("sueldo_empleado")]
        public int SueldoEmpleado { get; set; }

        [ForeignKey("Sexo")]
        public int Sexo { get; set; }
        public int IdSexo { get; set; }

        [Column("imagen_empleado")]
        public byte[] ImagenEmpleado { get; set; }

        // Relación con el Tipo de Empleado
        public TipoEmpleadoModel TipoEmpleado { get; set; }
        public int IdTipoEmpleado { get; set; }
        public ComunaModel Comuna { get; set; }
        public int IdComuna { get; set; }
        // Relación con el Sexo
        public SexoModel SexoEmpleado { get; set; }
    }
}
