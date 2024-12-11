using Microsoft.AspNetCore.Mvc;
using Models;

[ApiController]
[Route("MinimalCinema/[controller]")]
public class HorarioController : ControllerBase
{
    private static List<Horarios> horarios = new List<Horarios>();

    public HorarioController()
    {
        if (horarios.Count == 0)
        {
            InicializarHorarios();
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Horarios>> GetAllHorarios()
    {
        return Ok(horarios);
    }

    [HttpGet("{id}")]
    public ActionResult<Horarios> GetHorarioById(int id)
    {
        var horario = horarios.FirstOrDefault(h => h.Id == id);
        if (horario == null)
        {
            return NotFound($"Horario con ID {id} no encontrado.");
        }
        return Ok(horario);
    }

    private static void InicializarHorarios()
    {
        horarios.Add(new Horarios(1, "10:00 AM"));
        horarios.Add(new Horarios(2, "2:00 PM"));
        horarios.Add(new Horarios(3, "6:00 PM"));
        horarios.Add(new Horarios(4, "9:00 PM"));
    }

    public static List<Horarios> GetHorarios()
    {
        return horarios;
    }
}
