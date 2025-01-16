// File:    NotificationService.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 10:10:58 PM
// Purpose: Definition of Class NotificationService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class NotificationService
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
      
      public Classes.Repository.NotificationRepository notificationRepository;
   
   }
}