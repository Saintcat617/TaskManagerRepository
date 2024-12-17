namespace TaskManager.Api.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Titulo { get; set; } // Permite null
        public string? Descripcion { get; set; } // Permite null
        public string? Estado { get; set; } // Permite null
        public int? UsuarioAsignadoId { get; set; } // Permite null
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
