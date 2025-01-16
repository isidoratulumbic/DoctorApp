using System;

namespace Classes.Model
{
   public class User
   {
      public int id { get; set; }
      public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string jmbg { get; set; }
        public string phoneNumber { get; set; }
        public string feedback { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }


        public System.Collections.Generic.List<NotificationRefferal> notificationRefferal;    //zasto 2?
      
      public System.Collections.Generic.List<NotificationRefferal> NotificationRefferal
      {
         get
         {
            if (notificationRefferal == null)
               notificationRefferal = new System.Collections.Generic.List<NotificationRefferal>();
            return notificationRefferal;
         }
         set
         {
            RemoveAllNotificationRefferal();
            if (value != null)
            {
               foreach (NotificationRefferal oNotificationRefferal in value)
                  AddNotificationRefferal(oNotificationRefferal);
            }
         }
      }
      
      public void AddNotificationRefferal(NotificationRefferal newNotificationRefferal)
      {
         if (newNotificationRefferal == null)
            return;
         if (this.notificationRefferal == null)
            this.notificationRefferal = new System.Collections.Generic.List<NotificationRefferal>();
         if (!this.notificationRefferal.Contains(newNotificationRefferal))
            this.notificationRefferal.Add(newNotificationRefferal);
      }
      
     
      public void RemoveNotificationRefferal(NotificationRefferal oldNotificationRefferal)
      {
         if (oldNotificationRefferal == null)
            return;
         if (this.notificationRefferal != null)
            if (this.notificationRefferal.Contains(oldNotificationRefferal))
               this.notificationRefferal.Remove(oldNotificationRefferal);
      }
      
      public void RemoveAllNotificationRefferal()
      {
         if (notificationRefferal != null)
            notificationRefferal.Clear();
      }
   
   }
}