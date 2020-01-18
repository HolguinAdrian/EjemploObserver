using System;

namespace EjemploObserver
{
    public class ObservadorCompilador : IObservadorPublicador
    {
        private ObservadoContenedorCodigo observadoContenedorCodigo;

        public ObservadorCompilador(ObservadoContenedorCodigo observadoContenedorCodigo)
        {
            this.observadoContenedorCodigo = observadoContenedorCodigo;
        }

        public void actualizar(string datos)
        {
            Console.WriteLine($"Se reciben los datos: {datos}, se ejecutarán PUs");
            observadoContenedorCodigo.EjecutarPU();
        }
    }
}
