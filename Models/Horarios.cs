public class Horarios
{
    public int Id { get; set; }
    public string Horario { get; set; }

    public Horarios(int numero, string horario)
    {
        Id = numero;
        Horario = horario;
    }
}
