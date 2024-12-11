using Models;

public class Sesion
{
    public int Id { get; set; }
    public Pelicula Pelicula { get; set; }
    public Sala Sala { get; set; }
    public Horarios Horario { get; set; } 

    public Sesion(int id, Pelicula pelicula, Sala sala, Horarios horario)
    {
        Id = id;
        Pelicula = pelicula;
        Sala = sala;
        Horario = horario;
    }
}
