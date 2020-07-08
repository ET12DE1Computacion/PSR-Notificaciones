using Notificaciones.Core.Notis;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Notificaciones.Core
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long? Telefono { get; set; }
        public long? Celular { get; set; }
        public string Email { get; set; }
        public List<Notificacion> Notificaciones { get; set; }
        public Usuario()
        {
            Notificaciones = new List<Notificacion>();
        }
        public void Notificar()
            => Notificaciones.ForEach(n => n.Notificar());
        public async Task NotificarAsync()
        {
            await Task.Run(() => Parallel.ForEach(Notificaciones, noti => noti.NotificarAsync()));
        }
        public void AgregarNotificacion(Notificacion notificacion)
        {
            Notificaciones.Add(notificacion);
            notificacion.Usuario = this;
        }
        public void AgregarNotificacion(List<Notificacion> notificaciones)
            => notificaciones.ForEach(n => AgregarNotificacion(n));
    }
}