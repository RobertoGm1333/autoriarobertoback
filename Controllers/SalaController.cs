using Microsoft.AspNetCore.Mvc;
using Models;

namespace back_1_trimestre_2_daw.Controllers
{
    [ApiController]
    [Route("MinimalCinema/[controller]")]
    public class SalaController : ControllerBase
    {
        private static List<Sala> salas = new List<Sala>();

        public SalaController()
        {
            if (salas.Count == 0)
            {
                InicializarSalas();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sala>> GetAll()
        {
            return Ok(salas);
        }

        [HttpGet("{id}")]
        public ActionResult<Sala> GetById(int id)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
                return NotFound();
            return Ok(sala);
        }

        [HttpGet("{id}/asientos")]
        public ActionResult<IEnumerable<Asiento>> GetAsientos(int id)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
                return NotFound();

            return Ok(sala.Asientos);
        }



        [HttpPost]
        public ActionResult<Sala> Create([FromBody] Sala nuevaSala)
        {
            nuevaSala.Id = salas.Count > 0 ? salas.Max(s => s.Id) + 1 : 1;
            nuevaSala.Asientos = InicializarAsientos(nuevaSala.Capacidad);
            salas.Add(nuevaSala);
            return CreatedAtAction(nameof(GetById), new { id = nuevaSala.Id }, nuevaSala);
        }


        [HttpPut("{id}/asientos/{numero}")]
        public ActionResult ActualizarEstadoAsiento(int id, int numero, [FromBody] bool estaReservado)
        {
            var sala = salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
                return NotFound("Sala no encontrada");

            var asiento = sala.Asientos.FirstOrDefault(a => a.Numero == numero);
            if (asiento == null)
                return NotFound("Asiento no encontrado");

            asiento.EstaReservado = estaReservado; // Actualiza el estado del asiento
            return NoContent(); // Respuesta de éxito sin contenido
        }


        private static void InicializarSalas()
        {
            salas.Add(new Sala(1, "Sala 1", 100, InicializarAsientos(100)));
            salas.Add(new Sala(2, "Sala 2", 100, InicializarAsientos(100)));
            salas.Add(new Sala(3, "Sala 3", 100, InicializarAsientos(100)));
            salas.Add(new Sala(4, "Sala 4", 100, InicializarAsientos(100)));
            salas.Add(new Sala(5, "Sala 5", 100, InicializarAsientos(100)));
            salas.Add(new Sala(6, "Sala 6", 100, InicializarAsientos(100)));
        }

        private static List<Asiento> InicializarAsientos(int capacidad)
        {
            var asientos = new List<Asiento>();
            for (int i = 1; i <= capacidad; i++)
            {
                asientos.Add(new Asiento(i, false)); // Todos los asientos no están reservados inicialmente
            }
            return asientos;
        }

                public static List<Sala> GetSalas()
        {
            return salas;
        }
    }
}
