using System.ComponentModel.DataAnnotations;
namespace EjercicioCRUD.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage ="El campo es incorrecto")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo es incorrecto")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo es incorrecto")]
        public string? Correo { get; set; }
    }
}
