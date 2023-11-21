using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("Tipo_cliente")]
    public class TipoClienteModel
    {
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "La descripción del tipo de cliente es obligatoria.")]
        [Display(Name = "Descripción del Tipo de Cliente")]
        [Column("descripcion_tipo_cliente")]
        public string DescripcionTipoCliente { get; set; }
    }
}
