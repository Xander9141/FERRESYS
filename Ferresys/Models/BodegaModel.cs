#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class BodegaModel
    {
        [Key]
        [Column("id_bodega")]
        public int IdBodega { get; set; }

        [Required(ErrorMessage = "El campo Descripción de Bodega es obligatorio.")]
        [Column("descripcion_bodega")]
        public string DescripcionBodega { get; set; }

        [Required(ErrorMessage = "El campo Dirección de Bodega es obligatorio.")]
        [Column("direccion_bodega")]
        public string DireccionBodega { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Creación es obligatorio.")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Actualización es obligatorio.")]
        [Column("fecha_actualizacion")]
        public DateTime FechaActualizacion { get; set; }

        // Agregar esta propiedad para representar la relación con Region
        [ForeignKey("regiones_id_region")]
        public int RegionId { get; set; }
        public RegionModel Region { get; set; }
    }
}
