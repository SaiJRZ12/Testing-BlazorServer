using BlazorServer.Components.Models;

namespace BlazorServer.Components.Services
{
    public interface IProfesorService
    {
        Task<List<Profesor>> GetProfesoresAsync();
        Task<Profesor?> GetProfesorByIdAsync(int id);
        Task AddProfesorAsync(Profesor profesor);
        Task UpdateProfesorAsync(Profesor profesor);
        Task DeleteProfesorAsync(int id);
    }
}
