#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class ComunaModel
    {
        [Key]
        [Column("id_comuna")]
        public int IdComuna { get; set; }

        [Required(ErrorMessage = "El campo Nombre de Comuna es obligatorio.")]
        [Column("nombre_comuna")]
        public string NombreComuna { get; set; }

        [Required(ErrorMessage = "El campo Region es obligatorio.")]
        [Column("Regiones_id_region")]
        public int IdRegion { get; set; }


    }
}
