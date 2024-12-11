namespace Models;

class Pedido {

    private List<Pelicula> peliculas;

    public Pedido(){
        peliculas = new List<Pelicula>();
    }

    public void AñadirProducto(Pelicula pelicula){

        peliculas.Add(pelicula);
        Console.WriteLine($"Pelicula Añadida: {pelicula.Nombre}");

    }

    public void MostrarDetalles(){

        Console.WriteLine("/n--------------------Pedido--------------------");
        foreach (Pelicula pelicula in peliculas){

            pelicula.MostrarDetalles();

        }

    }

    public double CalcularTotal(){

        double total = 0;

        foreach (Pelicula pelicula in peliculas){

            total += pelicula.Precio;

        } return total;

    }


}