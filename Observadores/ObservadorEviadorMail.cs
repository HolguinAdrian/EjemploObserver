using System;

namespace EjemploObserver
{
    public class ObservadorEviadorMail : IObservadorPublicador
    {
        private ObservadoContenedorCodigo observadoContenedorCodigo;

        public ObservadorEviadorMail(ObservadoContenedorCodigo observadoContenedorCodigo)
        {
            this.observadoContenedorCodigo = observadoContenedorCodigo;
        }

        public void actualizar(string datos)
        {
            Console.WriteLine($"Se reciben los datos: {datos}, se envía Email");
        }
    }
}
