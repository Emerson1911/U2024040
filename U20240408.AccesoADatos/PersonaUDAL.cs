using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U20240408.EntidadesDeNegocio;

namespace U20240408.AccesoADatos
{
    public class PersonaUDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaUDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaU personaU)
        {
            _appDbContext.Add(personaU);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaU personaU)
        {
            var PersonaData = await _appDbContext.PersonaU.FirstOrDefaultAsync(s => s.Id == personaU.Id);
            if (PersonaData != null)
            {
                PersonaData.NombreU = personaU.NombreU;
                PersonaData.ApellidoU = personaU.ApellidoU;
                PersonaData.FechaNacimientoU = personaU.FechaNacimientoU;
                PersonaData.SueldoU = personaU.SueldoU;
                PersonaData.EstatusU = personaU.EstatusU;
                _appDbContext.Update(PersonaData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaU personaU)
        {
            var PersonaData = await _appDbContext.PersonaU.FirstOrDefaultAsync(s => s.Id == personaU.Id);
            if (PersonaData != null)
                _appDbContext.Remove(PersonaData);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaU> ObtenerPoId(PersonaU personaU)
        {
            var PersonaData = await _appDbContext.PersonaU.FirstOrDefaultAsync(s => s.Id == personaU.Id);
            if (PersonaData != null)
                return PersonaData;
            else
                return new PersonaU();
        }
        public async Task<List<PersonaU>> ObtenerTodos()
        {
            return await _appDbContext.PersonaU.ToListAsync();
        }
        public async Task<List<PersonaU>> Buscar(PersonaU personaU)
        {
            var query = _appDbContext.PersonaU.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaU.NombreU))
            {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                query = query.Where(s => s.NombreU.Contains(personaU.NombreU));
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            }
            if (!string.IsNullOrWhiteSpace(personaU.ApellidoU))
            {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                query = query.Where(s => s.ApellidoU.Contains(personaU.ApellidoU));
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            }
            return await query.ToListAsync();
        }
    }
}
