using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UT03_02WebApi.Models;

namespace UT03_02WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JuegosController : ControllerBase
    {

        private static List<Juego> Juegos = new List<Juego>()
        {
            new Juego {
                   Id = 1,
                   Genre = "Guerra",
                   Title = "WarHammer"
        },
            new Juego {
                Id = 2,
                Genre = "Deporte",
                Title = "Fifa"
        },
            new Juego {
                Id=3,
                Genre="Aventura",
                Title="Last of us"
            }

        };

        private readonly ILogger<JuegosController> _logger;

        public JuegosController(ILogger<JuegosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetJuego")]
        public IActionResult Get()
        {
            return Ok(Juegos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
                var game = Juegos.Find(a => a.Id == id);
                if (game == null)
                {
                    return NotFound();
                }

                return Ok(game);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Juego juego)
        {
            if (ModelState.IsValid)
            {
                int idJuego = Juegos.Last().Id;
                if (juego == null)
                {
                    return NotFound();
                }
                juego.Id = idJuego + 1;
                Juegos.Add(juego);
                return CreatedAtAction(nameof(Get), nameof(JuegosController), juego);
            }
            return BadRequest();
        }
        /*UPDATE*/
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] Juego juego)
        {
            Juego game=Juegos.Find(a => a.Id == id);
            if (ModelState.IsValid)
            {
                if (game == null)
                {
                    return NotFound();
                }
                game.Id = juego.Id;
                game.Title = juego.Title;
                game.Genre = juego.Genre;
                return Ok(game);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, Juego juego)
        {
            Juego game = Juegos.Find(a => a.Id == id);
            if (ModelState.IsValid)
            {

                if (game == null)
                {
                    return NotFound();
                }
                Juegos.Remove(game);
                return Ok(game);
            }
            return BadRequest();
        }
    }
}
