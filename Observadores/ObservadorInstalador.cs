using System;

namespace EjemploObserver
{
    public class ObservadorInstalador : IObservadorPublicador
    {
        public void actualizar(int estado)
        {
            if (estado == 4)
            {
                string res = string.Empty;
                res += "Instalando Última versión...\n";

                Console.WriteLine(res);
            }
        }
    }
}
