using System.Collections.Generic;
using System.Threading;

namespace EjemploObserver
{
    public class ObservadoContenedorCodigo : IObservadoContenedorCodigo
    {
        string codigo;
        string desc;
        List<IObservadorPublicador> lstObservadores;
        public int estado;

        public ObservadoContenedorCodigo()
        {
            lstObservadores = new List<IObservadorPublicador>();
        }

        public void AgregarObservador(IObservadorPublicador o)
        {
            lstObservadores.Add(o);
        }

        public void Notificar()
        {
            foreach (IObservadorPublicador obs in lstObservadores)
            {
                obs.actualizar(estado);
            }
        }

        public void QuitarObservador(IObservadorPublicador o)
        {
            lstObservadores.Remove(o);
        }

        public void PublicarCodigo(string _cod, string _desc)
        {
            estado = 1;

            codigo = _cod;
            desc = _desc;
            Notificar();
            Thread.Sleep(1000);
            CompilarCodigo();
        }

        public void CompilarCodigo()
        {
            estado = 2;
            Notificar();
            Thread.Sleep(1000);
            EjecutarPU();

        }

        public void EjecutarPU()
        {
            estado = 3;
            Notificar();
            Thread.Sleep(1000);
            ActualizarCodigo();
        }

        public void ActualizarCodigo()
        {
            estado = 4;
            Notificar();
            Thread.Sleep(1000);
            EnviarEmail();
        }

        public void EnviarEmail()
        {
            estado = 5;
            Thread.Sleep(1000);
            Notificar();
        }
    }
}
