﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace UT03_04WebApiJWT.Models;

public partial class Game
{
        [Key]
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int GenreId { get; set; }
        [JsonIgnore]
        public Genre? Genre { get; set; }

}