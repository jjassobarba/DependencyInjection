using Game.Clases.Armas;
using Game.Clases.Personajes;
using Game.Interfaces;
using Ninject.Modules;

namespace Game.Clases.Bindings
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonaje>().To<Paladin>();
            Bind<IArmas>().To<Espada>();
        }
    }
}
