using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploObserver
{

    class Program
    {
        static void Main(string[] args)
        {
            IObservadorPublicador publicadorCodigo = new ObservadorPublicador();
            IObservadorPublicador observadorcompilador = new ObservadorCompilador();
            IObservadorPublicador observadorEjecutador = new ObservadorEjecutadorPU();
            IObservadorPublicador observadorActualizador = new ObservadorInstalador();
            IObservadorPublicador enviadorMail = new ObservadorEviadorMail();

            ObservadoContenedorCodigo observadoContenedorCodigo = new ObservadoContenedorCodigo();

            observadoContenedorCodigo.AgregarObservador(publicadorCodigo);
            observadoContenedorCodigo.AgregarObservador(observadorcompilador);
            observadoContenedorCodigo.AgregarObservador(observadorEjecutador);
            observadoContenedorCodigo.AgregarObservador(observadorActualizador);
            observadoContenedorCodigo.AgregarObservador(enviadorMail);

            observadoContenedorCodigo.PublicarCodigo("<code>...<\\code>", "Ejemplo de codigo de ejemplo.");

            Console.ReadKey();
        }
    }
}
