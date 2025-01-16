// File:    NotificationRepository.cs
// Author:  LENOVO
// Created: Friday, April 16, 2021 2:58:14 PM
// Purpose: Definition of Class NotificationRepository

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Repository
{
   public class NotificationRepository
   {
      public Classes.Model.NotificationRefferal GetNotificationById(int notificationId)
      {
         throw new NotImplementedException();
      }
      
      public List<NotificationRefferal> GetAllNotificationsFromUser(int userId)
      {
         throw new NotImplementedException();
      }
      
      public void deleteNotification(int notificationId)
      {
         throw new NotImplementedException();
      }
      
      public NotificationRefferal addNewNotification(Classes.Model.NotificationRefferal notification)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAllNotificationsFromUser(int userId)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}