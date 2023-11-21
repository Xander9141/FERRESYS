#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class RazonSocialModel
    {
        [Key]
        [Column("id_razon_social")]
        public int IdRazonSocial { get; set; }

        [Required(ErrorMessage = "La descripción de la Razón Social es obligatoria.")]
        [Column("descripcion_razon_social")]
        public string DescripcionRazonSocial { get; set; }
    }
}
