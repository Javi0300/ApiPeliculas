using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos
{
    public class Peliculas
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Director { get; set; }

        public string Genero { get; set; }

        public string Rating { get; set; }

        public DateTime AñoPublicacion { get; set; }
    }
}
