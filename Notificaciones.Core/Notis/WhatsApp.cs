namespace Notificaciones.Core.Notis;
public class WhatsApp : Notificacion
{
    public WhatsApp(Usuario usuario) : base(usuario) { }

    public override void Notificar()
        => Task.Delay(TimeSpan.FromSeconds(2)).Wait();
    public async override Task NotificarAsync()
        => await Task.Delay(TimeSpan.FromSeconds(2));
}