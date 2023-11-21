using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class ProveedorModel
    {
        [Key]
        [Column("id_proveedor")]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "El campo Rut es obligatorio.")]
        [Column("rut_proveedor")]
        public string RutProveedor { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [Column("nombre_proveedor")]
        public string NombreProveedor { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        [Column("apellido_proveedor")]
        public string ApellidoProveedor { get; set; }

        [Required(ErrorMessage = "La Dirección Central es obligatoria.")]
        [Column("direccion_central_proveedor")]
        public string DireccionCentralProveedor { get; set; }

        [Required(ErrorMessage = "La Dirección Secundaria es obligatoria.")]
        [Column("direccion_secundaria_proveedor")]
        public string DireccionSecundariaProveedor { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        [Column("telefono_proveedor")]
        public string TelefonoProveedor { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo electrónico válida.")]
        [Column("email_proveedor")]
        public string EmailProveedor { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        [Required(ErrorMessage = "La Razón Social es obligatoria.")]
        [Column("Razon_social_id_razon_social")]
        public int RazonSocialIdRazonSocial { get; set; }

        [Required(ErrorMessage = "La Región es obligatoria.")]
        [Column("Regiones_id_region")]
        public int RegionesIdRegion { get; set; }

        [Required(ErrorMessage = "La Ciudad es obligatoria.")]
        [Column("Ciudades_id_ciudad")]
        public int CiudadesIdCiudad { get; set; }

        [Required(ErrorMessage = "La Comuna es obligatoria.")]
        [Column("Comunas_id_comuna")]
        public int ComunasIdComuna { get; set; }

        // Relaciones
        [ForeignKey("RazonSocialIdRazonSocial")]
        public RazonSocialModel RazonSocial { get; set; }

        [ForeignKey("RegionesIdRegion")]
        public RegionModel Region { get; set; }


        [ForeignKey("ComunasIdComuna")]
        public ComunaModel Comuna { get; set; }
    }
}
