using System.Collections.Generic;

namespace Balta.NotificationContext{

    
    public abstract class Notifiable{

        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notification){

            Notifications.Add(notification);
        }

         public void AddNotifications(IEnumerable<Notification> notifications){

            Notifications.AddRange (notifications); // IList() não tem o metodo AddRange apenas o List()
        }

        public bool IsInvalid => Notifications.Any(); // objeto será invalido se houver alguma notificação de erro

    }
}