using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ferresys.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo de correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese una dirección de correo electrónico válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo de contraseña es obligatorio.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$", 
            ErrorMessage = "La contraseña debe tener entre 8 y 20 caracteres y contener al menos un número, una letra mayúscula y una letra minúscula.")]
        public string Password { get; set; }
    }
}
