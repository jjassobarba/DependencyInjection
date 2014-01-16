using System;
using Game.Clases;
using Game.Clases.Armas;
using Game.Clases.Bindings;
using Game.Clases.Personajes;
using Game.Clases.Servicios;
using Ninject;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var module = new Bindings();
            var kernel = new StandardKernel(module);
            ServicioPersonaje instantiatedService = null;
            ServicioArmas instantiatedWeapon = null;
            Console.WriteLine("Selecciona un personaje:");
            Console.WriteLine("1. Paladin");
            Console.WriteLine("2. Elfo");
            Console.WriteLine("3. Mago");
            Console.WriteLine("4. Default");
            var valorPersonaje = Console.ReadLine();
            switch (valorPersonaje)
            {
                case "1":
                    var paladin = new ServicioPersonaje(new Paladin());
                    instantiatedService = paladin;
                    break;
                case "2":
                    var elfo = new ServicioPersonaje(new Elfo());
                    instantiatedService = elfo;
                    break;
                case "3":
                    var mago = new ServicioPersonaje(new Mago());
                    instantiatedService = mago;
                    break;
                default:
                    var servicio = kernel.Get<ServicioPersonaje>();
                    var arma = kernel.Get<ServicioArmas>();
                    instantiatedService = servicio;
                    instantiatedWeapon = arma;
                    break;

            }
            Console.Clear();
            if (valorPersonaje != "4")
            {
                Console.WriteLine("Selecciona un arma:");
                Console.WriteLine("1. Espada");
                Console.WriteLine("2. Arco");
                Console.WriteLine("3. Hechizo");
            }
            var valorArma = Console.ReadLine();
            switch (valorArma)
            {
                case "1":
                    var espada = new ServicioArmas(new Espada());
                    instantiatedWeapon = espada;
                    break;
                case "2":
                    var arco = new ServicioArmas(new Arco());
                    instantiatedWeapon = arco;
                    break;
                case "3":
                    var hechizo = new ServicioArmas(new Hechizo());
                    instantiatedWeapon = hechizo;
                    break;
                default:
                    var arma = kernel.Get<ServicioArmas>();
                    instantiatedWeapon = arma;
                    break;

            }
            Console.Clear();
            Console.WriteLine(instantiatedService.GetPersonaje() + instantiatedWeapon.Usar());
            Console.ReadKey();
        }
    }
}
