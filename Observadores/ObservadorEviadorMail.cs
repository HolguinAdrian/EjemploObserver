using System;

namespace EjemploObserver
{
    public class ObservadorEviadorMail : IObservadorPublicador
    {
        public void actualizar(int estado)
        {
            if (estado == 5)
            {
                string res = string.Empty;
                res += "Enviando Email...\n";

                Console.WriteLine(res);
            }
        }
    }
}
