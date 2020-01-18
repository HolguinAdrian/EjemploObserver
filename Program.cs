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
            ObservadoContenedorCodigo observadoContenedorCodigo = new ObservadoContenedorCodigo();

            IObservadorPublicador publicadorCodigo = new ObservadorUploader(observadoContenedorCodigo);
            IObservadorPublicador observadorcompilador = new ObservadorCompilador(observadoContenedorCodigo);
            IObservadorPublicador observadorEjecutador = new ObservadorEjecutadorPU(observadoContenedorCodigo);
            IObservadorPublicador observadorActualizador = new ObservadorInstalador(observadoContenedorCodigo);
            IObservadorPublicador enviadorMail = new ObservadorEviadorMail(observadoContenedorCodigo);

            observadoContenedorCodigo.administradorObservadores.AgregarObservador(publicadorCodigo);
            observadoContenedorCodigo.administradorObservadores.AgregarObservador(observadorcompilador);
            observadoContenedorCodigo.administradorObservadores.AgregarObservador(observadorEjecutador);
            observadoContenedorCodigo.administradorObservadores.AgregarObservador(observadorActualizador);

            observadoContenedorCodigo.PublicarCodigo("<code>...<\\code>", "Ejemplo de codigo de ejemplo.");

            Console.ReadKey();
        }
    }
}
