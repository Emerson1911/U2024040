
using U20240408.AccesoADatos;

using U20240408.EntidadesDeNegocio;

namespace U20240408.LogicaDeNegocio
{
    public class PersonaUBL

    {
        readonly PersonaUDAL _personaUBL;

        public PersonaUBL(PersonaUDAL personaDAL)
        {
            _personaUBL = personaDAL;
        }
        public async Task<int> Crear(PersonaU personaU)
        {
            return await _personaUBL.Crear(personaU);
        }
        public async Task<int> Modificar(PersonaU personaU)
        {
            return await _personaUBL.Modificar(personaU);
        }
        public async Task<int> Eliminar(PersonaU personaU)
        {
            return await _personaUBL.Eliminar(personaU);
        }
        public async Task<PersonaU> ObtenerPoId(PersonaU personaU)
        {
            return await _personaUBL.ObtenerPoId(personaU);
        }
        public async Task<List<PersonaU>> ObtenerTodos()
        {
            return await _personaUBL.ObtenerTodos();
        }
        public async Task<List<PersonaU>> Buscar(PersonaU personaU)
        {
            return await _personaUBL.Buscar(personaU);
        }

    }
}
