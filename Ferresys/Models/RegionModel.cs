using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class RegionModel
    {
        [Key]
        [Column("id_region")]
        public int IdRegion { get; set; }

        [Required(ErrorMessage = "El campo Nombre de Región es obligatorio.")]
        [Column("nombre_region")]
        public string NombreRegion { get; set; }
    }
}
