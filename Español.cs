using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal class Español : InIdioma
    {
        public string idioma => "Español";

        public void dialogo()
        {
            Console.WriteLine("_________________-----------------------__________________");
            Console.WriteLine("_________________        " + idioma + "     __________________");
            Console.WriteLine("_________________-----------------------__________________");
            Console.WriteLine("Seleccione el héroe: 1. Link 2. Zelda");
            int tipoHeroe = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (tipoHeroe == 1)
                {
                    InBatalla batalla = new BatallaFinal(new Ganondorf(new Trifuerza()), new Link(new Espada(), new Arco()));
                    Console.WriteLine(batalla.PresentacionPersonaje(true) + ": " + batalla.Ataque(true));
                    Console.WriteLine(batalla.PresentacionPersonaje(false) + ": " + batalla.Ataque(false));
                    Console.WriteLine(batalla.PresentacionPersonaje(true) + ": " + batalla.Ataque(true));
                    Console.WriteLine(batalla.PresentacionPersonaje(false) + ": " + batalla.Ataque(false));
                }
                if (tipoHeroe == 2)
                {
                    InBatalla batalla = new BatallaFinal(new Ganondorf(new Trifuerza()), new Zelda(new Espada(), new Arco()));
                    Console.WriteLine(batalla.PresentacionPersonaje(true) + ": " + batalla.Ataque(true));
                    Console.WriteLine(batalla.PresentacionPersonaje(false) + ": " + batalla.Ataque(false));
                    Console.WriteLine(batalla.PresentacionPersonaje(true) + ": " + batalla.Ataque(true));
                    Console.WriteLine(batalla.PresentacionPersonaje(false) + ": " + batalla.Ataque(false));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccione una opción válida");
                throw;
            }
        }
    }
}
