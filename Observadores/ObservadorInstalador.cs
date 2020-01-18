using System;

namespace EjemploObserver
{
    public class ObservadorInstalador : IObservadorPublicador
    {
        private ObservadoContenedorCodigo observadoContenedorCodigo;

        public ObservadorInstalador(ObservadoContenedorCodigo observadoContenedorCodigo)
        {
            this.observadoContenedorCodigo = observadoContenedorCodigo;
        }

        public void actualizar(string datos)
        {
            Console.WriteLine($"Se reciben los datos: {datos}, se procederá a enviar un Email con los datos {datos}.");
            observadoContenedorCodigo.EnviarEmail();
        }
    }
}
