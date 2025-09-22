using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Components.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Titulacion { get; set; } = string.Empty;
    }
}
