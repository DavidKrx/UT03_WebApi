using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UT03_02WebApi.Models
{
    public class Juego
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Titulo")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "El titulo debe tener entre {2} y {1} caracteres.")]
        public string Title { get; set; }
        [DisplayName("Genero")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [StringLength(12, MinimumLength = 2, ErrorMessage = "El genero debe tener entre {2} y {1} caracteres.")]
        public string Genre { get; set; }
    }
}
