using EjemploObserver.SujetoObservado;
using System;
using System.Collections.Generic;
using System.Threading;

namespace EjemploObserver
{
    public class ObservadoContenedorCodigo
    {
        public AdministradorObservadores administradorObservadores;

        public ObservadoContenedorCodigo()
        {
            administradorObservadores = new AdministradorObservadores();
        }

        public void PublicarCodigo(string _cod, string _desc)
        {
            string s;
            Console.WriteLine($"\nSubiendo: {_cod}");
            Thread.Sleep(1000);
            if (true) // Solo simula que el proceso fue exitoso, si NO lo fuera no llama el evento y se hace otra cosa
            {  
                Console.WriteLine(s = "Publicado Exitoso");
                administradorObservadores.Notificar(typeof(ObservadorUploader), s);
            }
            else
                Console.WriteLine("Publicado No Exitoso");
        }

        public void CompilarCodigo()
        {
            string s;
            Console.WriteLine($"\nCompilando el código...");
            Thread.Sleep(2000);
            if (true)
            {
                Console.WriteLine(s = "Compilado Exitoso");
                administradorObservadores.Notificar(typeof(ObservadorCompilador), s);
            }
            else
                Console.WriteLine("Compilado No Exitoso");

        }

        public void EjecutarPU()
        {
            Console.WriteLine($"\nEjecutando PUs...");
            Thread.Sleep(2000);
            if (true)
            {
                string s;
                Console.WriteLine(s = "Ejecución de PU Exitosa");
                administradorObservadores.Notificar(typeof(ObservadorEjecutadorPU), s);
            }
            else
                Console.WriteLine("Ejecución de PU No Exitosa");
        }

        public void ActualizarCodigo()
        {
            string s;
            Console.WriteLine($"\nActualizando a la última versión...");
            Thread.Sleep(1000);
            if (true)
            {
                Console.WriteLine(s = "Actualización de Código Exitosa");
                administradorObservadores.Notificar(typeof(ObservadorInstalador), s);
            }
            else
                Console.WriteLine("Actualización No Exitosa");
        }

        public void EnviarEmail()
        {
            string s;
            Console.WriteLine($"\nEnviando Email con el resultado...");
            Thread.Sleep(1000);
            if (true)   // Solo simula que el proceso fue exitoso, si NO lo fuera no llama el evento y se hace otra cosa
            {
                Console.WriteLine(s = "Envío de Email exitoso");
                administradorObservadores.Notificar(typeof(ObservadorEviadorMail), s);
            }
            else
                Console.WriteLine("Enviado de Email No Exitosa");
        }
    }
}
