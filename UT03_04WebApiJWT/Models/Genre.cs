using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UT03_04WebApiJWT.Models;

[Table("Genre")]
public partial class Genre
{
    [Key]
    public int Id { get; set; }
    [DisplayName("Nombre")]
    [Required(ErrorMessage = "El campo es obligatorio.")]
    public string Name { get; set; }
    public List<Game>? Games { get; set; }
}