using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace mvcProyecto.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre(s) del Cliente")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [Display(Name = "Aepllido(s) del Cliente")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Celular es obligatorio")]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria")]
        [Display(Name = "Direccion de domicilio")]
        public string Direccion { get; set; }

        
        [Required(ErrorMessage = "El carnet es obligatorio")]
        [Display(Name = "Carnet de identidad")]
        public string Carnet { get; set; }
    }
}
