using System;

namespace EjemploObserver
{
    public class ObservadorUploader : IObservadorPublicador
    {
        private ObservadoContenedorCodigo observadoContenedorCodigo;

        public ObservadorUploader(ObservadoContenedorCodigo observadoContenedorCodigo)
        {
            this.observadoContenedorCodigo = observadoContenedorCodigo;
        }

        public void actualizar(string datos)
        {
            Console.WriteLine($"Se reciben los datos: {datos}, se compilará el código");
            observadoContenedorCodigo.CompilarCodigo();
        }
    }
}
