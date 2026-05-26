using Domain.Entities;
using Shared.DTOs;

namespace Shared.Extensions
{
    public static class EstudianteExtensions
    {
        public static EstudianteDto ToDto(this Estudiante estudiante)
        {
            return new EstudianteDto
            {
                Id = estudiante.Id,
                NombreCompleto = $"{estudiante.Nombre} {estudiante.Apellido}",
                NumeroDocumento = estudiante.NumeroDocumento,
                TipoDocumento = estudiante.TipoDocumento.ToString(),
                Estado = estudiante.Estado.ToString()
            };
        }
    }
}