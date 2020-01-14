using System;

namespace EjemploObserver
{
    public class ObservadorCompilador : IObservadorPublicador
    {
        public void actualizar(int estado)
        {
            if (estado == 2)
            {
                string res = string.Empty;
                res += "Compilando codigo...\n";

                Console.WriteLine(res);
            }
        }

    }
}
