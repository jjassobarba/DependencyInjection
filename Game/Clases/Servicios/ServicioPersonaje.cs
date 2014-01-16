using Game.Interfaces;
using Ninject;

namespace Game.Clases.Servicios
{
    class ServicioPersonaje
    {
        private readonly IPersonaje _repositorio;

        [Inject]
        public ServicioPersonaje(IPersonaje repositorio)
        {
            _repositorio = repositorio;
        }

        public string GetPersonaje()
        {
            return _repositorio.GetPersonaje();
        }
    }
}
