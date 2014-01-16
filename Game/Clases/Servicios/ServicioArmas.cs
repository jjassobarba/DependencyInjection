using Game.Interfaces;
using Ninject;

namespace Game.Clases.Servicios
{
    class ServicioArmas
    {
        private readonly IArmas _repositorio;

        [Inject]
        public ServicioArmas(IArmas repositorio)
        {
            _repositorio = repositorio;
        }

        public string Usar()
        {
            return _repositorio.Usar();
        }
    }
}
