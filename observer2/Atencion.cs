using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Atencion
    {
        //
        internal void nuevoSuscriptor(string nuevosuscriptor)
        {
            Console.Write("Nuevo en el canal , te has suscrito Aliss.");
        }

        internal void registra(Atencion atencion)
        {
            Console.WriteLine("Nuevo suscriptor.");
            
        }

        internal void nuevoobservador(Atencion atencion)
        {
            Console.WriteLine("Nueva notificacion , suscrito en el canal .\n");
        }

        internal void nuevoobservador(string observador)
        {
            throw new NotImplementedException();
        }
    }
}
