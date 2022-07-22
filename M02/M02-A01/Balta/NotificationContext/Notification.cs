namespace Balta.NotificationContext
{

    public sealed class Notification // classe sealed para evitar que seja extendida por outras classes, as notificações devem ser feitas por esta classe e suas propriedades
    {
        public string Property { get; set; }
        public string Message { get; set; }

        public Notification()
        {
            
        }
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }
    }

    







}