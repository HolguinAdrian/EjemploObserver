namespace EjemploObserver
{
    public interface IObservadoContenedorCodigo
    {
        void AgregarObservador(IObservadorPublicador o);
        void QuitarObservador(IObservadorPublicador o);
        void Notificar();
    }
}
