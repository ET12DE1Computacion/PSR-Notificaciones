namespace Notificaciones.Core.Notis
{
    public class Email : Notificacion
    {
        public Email(Usuario usuario) : base(usuario) { }

        public override void Notificar()
        {
            
        }

        public override Task NotificarAsync()
        {
            return Task.CompletedTask;
        }
    }
}
