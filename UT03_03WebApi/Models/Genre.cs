using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UT03_03WebApi.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string Name { get; set; }
        public List<Game>? Games { get; set; }
    }
}
