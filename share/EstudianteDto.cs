namespace Shared.DTOs
{
    public class EstudianteDto
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string TipoDocumento { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}