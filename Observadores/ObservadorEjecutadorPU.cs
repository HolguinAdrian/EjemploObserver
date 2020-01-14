using System;

namespace EjemploObserver
{
    public class ObservadorEjecutadorPU : IObservadorPublicador
    {
        public void actualizar(int estado)
        {
            if (estado == 3)
            {
                string res = string.Empty;
                res += "Ejecutando PU...\n";

                Console.WriteLine(res);
            }
        }
    }
}
