using Notificaciones.Core.Notis;

namespace Notificaciones.Core;
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public long? Telefono { get; set; }
    public long? Celular { get; set; }
    public string Email { get; set; }
    public List<Notificacion> Notificaciones { get; set; }
    public Usuario(int id, string nombre, string apellido, string email, long? celular = null, long? telefono = null)
    {
        Notificaciones = new List<Notificacion>();
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Telefono = telefono;
        Celular = celular;
    }
    public void Notificar()
        => Notificaciones.ForEach(n => n.Notificar());
    public async Task NotificarAsync()
        => await Task.Run(() => Parallel.ForEach(Notificaciones, noti => noti.NotificarAsync()));
    public void AgregarNotificacion(Notificacion notificacion)
    {
        Notificaciones.Add(notificacion);
        notificacion.Usuario = this;
    }
    public void AgregarNotificacion(List<Notificacion> notificaciones)
        => notificaciones.ForEach(n => AgregarNotificacion(n));
}