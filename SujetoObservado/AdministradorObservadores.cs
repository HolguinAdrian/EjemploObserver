using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploObserver.SujetoObservado
{
    public class AdministradorObservadores
    {
        private List<IObservadorPublicador> lstObservadoresPublicador;

        public AdministradorObservadores()
        {
            lstObservadoresPublicador = new List<IObservadorPublicador>();
        }

        public void AgregarObservador(IObservadorPublicador o)
        {
            lstObservadoresPublicador.Add(o);
        }

        public void QuitarObservador(IObservadorPublicador o)
        {
            lstObservadoresPublicador.Remove(o);
        }

        public void Notificar(Type t, string datos)
        {
            foreach (IObservadorPublicador obs in lstObservadoresPublicador.Where(w => w.GetType() == t))
            {
                obs.actualizar(datos);

            }
        }

    }
}
