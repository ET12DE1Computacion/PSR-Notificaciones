using System;
using System.Threading.Tasks;

namespace Notificaciones.Core.Notis
{
    public class Email : Notificacion
    {
        public override void Notificar()
        {
            
        }

        public override Task NotificarAsync()
        {
            return Task.CompletedTask;
        }
    }
}
