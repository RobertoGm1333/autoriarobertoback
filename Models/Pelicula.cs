namespace Models;

public class Pelicula{

    public int Id_Pelicula{get; set;}
    public string Nombre {get; set;}
    public string Descripcion {get; set;}    
    public string Actores {get; set;}
    public string Directores {get; set;}
    public double Duracion {get; set;}
    public double Precio {get; set;}
    public string Edad_Recomendada {get; set;}
    public string Caratula {get; set;}
    public int Id_Categoria {get;set;}
    public string Nombre_Categoria {get; set;}


    public Pelicula(int id_pelicula, string nombre, string descripcion, string actores, string directores, double duracion, double precio,string edad_recomendada,string caratula, int id_categoria, string nombre_categoria){

        Id_Pelicula = id_pelicula;
        Nombre = nombre;
        Descripcion = descripcion;
        Actores = actores;
        Directores = directores;
        Duracion = duracion;
        Precio = precio;
        Edad_Recomendada = edad_recomendada;
        Caratula = caratula;
        Id_Categoria = id_categoria;
        Nombre_Categoria = nombre_categoria;

    }

    public void MostrarDetalles(){

        Console.WriteLine($"Id_Pelicula: {Id_Pelicula}, Nombre: {Nombre}, Descripcion: {Descripcion}, Actores: {Actores}, Directores: {Directores}, Duracion: {Duracion},Precio: {Precio:C},Solo mayores de edad: {Edad_Recomendada}, Direccion de la caratula: {Caratula} ,Id_Categoria: {Id_Categoria},Nombre_Categoria: {Nombre_Categoria}");

    }


}