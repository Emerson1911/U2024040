using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U20240408.EntidadesDeNegocio;

namespace U20240408.AccesoADatos
{
    public class PersonaMDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaMDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaU personaM)
        {
            _appDbContext.Add(personaM);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaU personaM)
        {
            var PersonaData = await _appDbContext.PersonaU.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
            {
                PersonaData.NombreU = personaM.NombreU;
                PersonaData.ApellidoU = personaM.ApellidoU;
                PersonaData.FechaNacimientoU = personaM.FechaNacimientoU;
                PersonaData.SueldoU = personaM.SueldoU;
                PersonaData.EstatusU = personaM.EstatusU;
                _appDbContext.Update(PersonaData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaU personaM)
        {
            var PersonaData = await _appDbContext.PersonaU.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
                _appDbContext.Remove(PersonaData);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaU> ObtenerPoId(PersonaU personaM)
        {
            var PersonaData = await _appDbContext.PersonaU.FirstOrDefaultAsync(s => s.Id == personaM.Id);
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
                query = query.Where(s => s.NombreU.Contains(personaU.NombreU));
            }
            if (!string.IsNullOrWhiteSpace(personaU.ApellidoU))
            {
                query = query.Where(s => s.ApellidoU.Contains(personaU.ApellidoU));
            }
            return await query.ToListAsync();
        }
    }
}
