using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class misObservadores
    {
        public void alta(suscripcion nueva)
        {
            Console.WriteLine("iniciando suscripcion para unirte a mi canal.", nueva.Observador,nueva.notificacion);
            (new notificaciones()).envianoti(nueva.Observador, nueva.notificacion);
            if (nueva.unirtealcanal)
            {
                (new Atencion()).nuevoobservador(nueva.Observador);
            }
        }

        public List<NuevoIntegranteObservador> observers = new List<NuevoIntegranteObservador> ();
        public virtual void registra(NuevoIntegranteObservador observer)
        {
            observers.Add(observer);
        }
        public virtual void especial (suscripcion nueva)
        {
            Console.WriteLine("suscripcion exitosa ", nueva.notificacion, nueva.Observador);
            foreach (NuevoIntegranteObservador observer in observers)
            {
                observer.nueva(nueva);
            }
        }
    }
}
