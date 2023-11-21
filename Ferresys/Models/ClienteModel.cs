#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("Clientes")]
    public class ClienteModel
    {
        [Key]
        public int id_cliente { get; set; }

        [Required(ErrorMessage = "El campo RUT del cliente es obligatorio.")]
        public string rut_cliente { get; set; }

        [Required(ErrorMessage = "El campo Nombre del cliente es obligatorio.")]
        public string nombre_cliente { get; set; }

        [Required(ErrorMessage = "El campo Apellido Paterno del cliente es obligatorio.")]
        public string apellido_paterno_cliente { get; set; }

        [Required(ErrorMessage = "El campo Apellido Materno del cliente es obligatorio.")]
        public string apellido_materno_cliente { get; set; }

        [Required(ErrorMessage = "El campo Dirección Central del cliente es obligatorio.")]
        public string direccion_central_cliente { get; set; }

        public string direccion_secundaria_cliente { get; set; }

        [Required(ErrorMessage = "El campo Teléfono del cliente es obligatorio.")]
        public string telefono_cliente { get; set; }

        [Required(ErrorMessage = "El campo Email del cliente es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email del cliente no tiene un formato válido.")]
        public string email_cliente { get; set; }

        public DateTime fecha_creacion { get; set; } = DateTime.Now;

        public DateTime fecha_actualizacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Tipo de Cliente es obligatorio.")]
        [ForeignKey("TipoCliente")]
        public int IdTipoCliente { get; set; }

        [Required(ErrorMessage = "El campo Razón Social es obligatorio.")]
        [ForeignKey("RazonSocial")]
        public int IdRazonSocial { get; set; }


        [Required(ErrorMessage = "El campo Región es obligatorio.")]
        [ForeignKey("Region")]
        public int IdRegion { get; set; }

        [Required(ErrorMessage = "El campo Comuna es obligatorio.")]
        [ForeignKey("Comuna")]
        public int IdComuna { get; set; }

        [Required(ErrorMessage = "El campo Sexo es obligatorio.")]
        [ForeignKey("Sexo")]
        public int IdSexo { get; set; }

        public SexoModel Sexo { get; set; }

        public RegionModel Region { get; set; }
    public TipoClienteModel TipoCliente { get; set; }
    public ComunaModel Comuna { get; set; }
    public RazonSocialModel RazonSocial { get; set; }

    }
}
