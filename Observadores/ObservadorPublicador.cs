using System;

namespace EjemploObserver
{
    public class ObservadorPublicador : IObservadorPublicador
    {
        public void actualizar(string codigo, string descripcion, int estado)
        {
            actualizar(estado);
        }

        public void actualizar(int estado)
        {
            if (estado == 1)
            {
                string res = string.Empty;
                res += "Código subido...\n";

                Console.WriteLine(res);
            }
        }
    }
}
