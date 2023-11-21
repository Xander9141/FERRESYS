#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("Sexo")]
    public class SexoModel
    {
        [Key]
        [Column("id_sexo")]
        public int IdSexo { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }
    }
}
