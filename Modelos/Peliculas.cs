using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos
{
    public class Peliculas
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(50)]
        public string Director { get; set; }

        [Required]
        [StringLength(50)]
        public string Genero { get; set; }

        [Required]
        [StringLength(2)]
        public int Rating { get; set; }

        [Required]
        public DateTime AñoPublicacion { get; set; }
    }
}
