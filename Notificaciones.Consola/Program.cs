using Notificaciones.Core;
using Notificaciones.Core.Notis;
using System.Diagnostics;
using static System.Console;

var pepito = new Usuario
(
    id: 100,
    nombre: "Jose",
    apellido: "Garcia",
    telefono: 1140004000,
    celular: 1140004001,
    email: $"joseg@1234.com"
);

var notis = new List<Notificacion>
            {
                //notificacion que tarda 5 segundos
                new Sms(pepito),

                //notificacion que tarda 2 segundos
                new WhatsApp(pepito),

                //notificacion que casi no tarda nada
                new Email(pepito)
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
