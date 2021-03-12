using System;

namespace EjemploObserver
{     
    public class ObservadorEjecutadorPU : IObservadorPublicador
    {
        private ObservadoContenedorCodigo observadoContenedorCodigo;

        public ObservadorEjecutadorPU(ObservadoContenedorCodigo observadoContenedorCodigo)
        {
            this.observadoContenedorCodigo = observadoContenedorCodigo;
        }

        public void actualizar(string datos)
        {
            Console.WriteLine($"Se reciben los datos: {datos}, se Actualizará a la última versión");
            observadoContenedorCodigo.ActualizarCodigo();
        }
    }
}
