using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface NuevoIntegranteObservador
    {
        //en esta interfaz  se le agrega el metodo nueva
        public void nueva(suscripcion nueva);
    }
}
