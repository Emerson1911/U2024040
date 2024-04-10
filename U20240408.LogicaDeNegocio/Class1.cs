
using U20240408.AccesoADatos;

using U20240408.EntidadesDeNegocio;

namespace U20240408.LogicaDeNegocio
{
    public class PersonaMBL

    {
        readonly PersonaMDAL _personaMBL;

        public PersonaMBL(PersonaMDAL personaDAL)
        {
            _personaMBL = personaDAL;
        }
        public async Task<int> Crear(PersonaU personaM)
        {
            return await _personaMBL.Crear(personaM);
        }
        public async Task<int> Modificar(PersonaU personaM)
        {
            return await _personaMBL.Modificar(personaM);
        }
        public async Task<int> Eliminar(PersonaU personaM)
        {
            return await _personaMBL.Eliminar(personaM);
        }
        public async Task<PersonaU> ObtenerPoId(PersonaU personaM)
        {
            return await _personaMBL.ObtenerPoId(personaM);
        }
        public async Task<List<PersonaU>> ObtenerTodos()
        {
            return await _personaMBL.ObtenerTodos();
        }
        public async Task<List<PersonaU>> Buscar(PersonaU personaM)
        {
            return await _personaMBL.Buscar(personaM);
        }

    }
}
