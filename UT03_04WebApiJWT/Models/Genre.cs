using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UT03_04WebApiJWT.Models;

[Table("Genre")]
public partial class Genre
{
    [Key]
    public int Id { get; set; }
    [DisplayName("Nombre")]
    [Required(ErrorMessage = "El campo es obligatorio.")]
    public string Name { get; set; }
    [JsonIgnore]
    public List<Game>? Games { get; set; }
}