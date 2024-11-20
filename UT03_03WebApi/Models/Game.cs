using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UT03_03WebApi.Models
{
    public class Game
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

             public int GenreId { get; set; }
             public Genre? Genre { get; set; }

        }
}

