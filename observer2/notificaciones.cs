using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class notificaciones : suscripcion, NuevoIntegranteObservador
    {
        //  en esta clase notificacion va a heredar de la clase suscripcion y de la interfaz NuevoIntegranteObservador

        public void nueva(suscripcion nueva)
        {
            Console.Write("Nuevo notificacion Aliss, te has suscrito .\n", nueva.Observador, nueva.notificacion);

        }

        internal void envianoti(string observador, string notificacion)
        {
            Console.Write("Nuevo email: enterate! , documentales nuevos.\n", observador , notificacion);
        }
    }
}
