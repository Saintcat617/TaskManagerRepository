namespace TaskManager.Api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; } // Permite null
        public string? Correo { get; set; } // Permite null
        public string? ContraseñaHash { get; set; } // Permite null
        public string? Rol { get; set; } // Permite null
    }

}
