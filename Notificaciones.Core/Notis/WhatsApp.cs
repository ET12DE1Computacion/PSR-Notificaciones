using System;
using System.Threading.Tasks;

namespace Notificaciones.Core.Notis
{
    public class WhatsApp : Notificacion
    {
        public override void Notificar()
            => Task.Delay(TimeSpan.FromSeconds(2)).Wait();
        public async override Task NotificarAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}