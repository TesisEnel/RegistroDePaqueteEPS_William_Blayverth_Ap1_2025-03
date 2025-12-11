using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RegistroDePaqueteEPS.Data;
using RegistroDePaqueteEPS.Models;
using static RegistroDePaqueteEPS.Components.Pages.Rembolsos.RembolsosCreate;

namespace RegistroDePaqueteEPS.Services
{
    public class ReembolsosService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;

        public ReembolsosService(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<bool> Guardar(Reembolso reembolso)
        {
            if (!await Existe(reembolso.ReembolsoId))
                return await Insertar(reembolso);
            else
                return await Modificar(reembolso);
        }

        private async Task<bool> Insertar(Reembolso reembolso)
        {
            using var contexto = await _dbFactory.CreateDbContextAsync();
            contexto.Reembolsos.Add(reembolso);
            return await contexto.SaveChangesAsync() > 0;
        }

        private async Task<bool> Modificar(Reembolso reembolso)
        {
            using var contexto = await _dbFactory.CreateDbContextAsync();

            // Actualizar la entidad principal
            contexto.Reembolsos.Update(reembolso);

            // Manejo básico de detalles (opcional, si decides editarlos después)
            // Para ediciones complejas de detalles, se recomienda borrar los anteriores e insertar los nuevos
            // o manejar el estado de cada uno.

            return await contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Reembolsos.AnyAsync(r => r.ReembolsoId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            using var contexto = await _dbFactory.CreateDbContextAsync();
            var reembolso = await contexto.Reembolsos.FindAsync(id);
            if (reembolso != null)
            {
                contexto.Reembolsos.Remove(reembolso);
                return await contexto.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
        
}