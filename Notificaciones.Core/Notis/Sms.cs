namespace Notificaciones.Core.Notis;
public class Sms : Notificacion
{
    public Sms(Usuario usuario) : base(usuario) { }

    public override void Notificar()
        => Task.Delay(TimeSpan.FromSeconds(5)).Wait();

    public override Task NotificarAsync()
    {
        Task.Delay(TimeSpan.FromSeconds(5)).Wait();
        return Task.CompletedTask;
    }
}