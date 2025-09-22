using BlazorServer.Components.Data;
using BlazorServer.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Components.Services
{
    public class ProfesorService : IProfesorService
    {
        private readonly AppDbContext _context;

        public ProfesorService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Profesor>> GetProfesoresAsync()
        {
            return await _context.Profesores.ToListAsync();
        }
        public async Task<Profesor?> GetProfesorByIdAsync(int id)
        {
            return await _context.Profesores.FindAsync(id);
        }

        public async Task AddProfesorAsync(Profesor profesor)
        {
            _context.Profesores.Add(profesor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProfesorAsync(Profesor profesor)
        {
            var trackedEntity = _context.Profesores.Local.FirstOrDefault(e => e.Id == profesor.Id);

            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).State = EntityState.Detached;
            }

            _context.Profesores.Update(profesor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProfesorAsync(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor != null)
            {
                _context.Profesores.Remove(profesor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
