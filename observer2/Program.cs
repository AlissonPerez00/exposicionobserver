using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            string nuevo ;
            // en esta parte pedimos datos 
            // y si el usuario desea ser  suscrito
            Console.WriteLine("HOLA, ESCRIBE TU NOMBRE");
            nuevo = Console.ReadLine();

            Console.WriteLine("¿TE SUSCRIBES?");
            nuevo = Console.ReadLine();
            //se instancia la clase misObservadores
            misObservadores matriculador = new misObservadores();
            Atencion observador = new Atencion();
            matriculador.alta(new notificaciones());
            matriculador.especial(new notificaciones());
            matriculador.registra(new notificaciones());
            observador.registra(new Atencion());
            observador.nuevoobservador(new Atencion());
        }
    }
}
