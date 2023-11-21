#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    [Table("usuarios")]
    public class UsuarioModel
    {
        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El campo Usuario es obligatorio.")]
        [Column("usuario")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [Column("password")]
        public string Password { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Column("fecha_actualizacion")]
        public DateTime? FechaActualizacion { get; set; }
    }
}
