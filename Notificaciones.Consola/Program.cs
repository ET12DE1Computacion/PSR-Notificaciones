using Notificaciones.Core;
using Notificaciones.Core.Notis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using static System.Console;

namespace Notificaciones.Consola
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var pepito = new Usuario()
            {
                Id = 100,
                Nombre = "Jose",
                Apellido = "Garcia",
                Telefono = 1140004000,
                Celular = 1140004001,
                Email = $"joseg@1234.com"
            };

            var notis = new List<Notificacion>
            {
                //notificacion que tarda 5 segundos
                new Sms(),

                //notificacion que tarda 2 segundos
                new WhatsApp(),

                //notificacion que casi no tarda nada
                new Email()
            };

            pepito.AgregarNotificacion(notis);

            //Clase propia de C#, representa un cronometro
            var cronometro = new Stopwatch();
            WriteLine("Comenzando notificaciones secuenciales");
            cronometro.Start();
            pepito.Notificar();
            TimeSpan i1 = cronometro.Elapsed;
            WriteLine($"Notificación secuencial: {i1.TotalSeconds} segundos");

            WriteLine("\nComenzando notificaciones en paralelo");
            cronometro.Restart();
            await pepito.NotificarAsync();
            TimeSpan i2 = cronometro.Elapsed;
            WriteLine($"Notificación paralela: {i2.TotalSeconds} segundos");
            ReadKey();
        }
    }
}