namespace Notificaciones.Core.Notis;
public abstract class Notificacion
{
    public Usuario Usuario { get; set; }

    public Notificacion(Usuario usuario)
        => Usuario = usuario;
    public abstract void Notificar();
    public abstract Task NotificarAsync();
}