// File:    NotificationController.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 10:11:56 PM
// Purpose: Definition of Class NotificationController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class NotificationController
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
      
      public NotificationRefferal createNotification(Classes.Model.NotificationRefferal notification)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAllNotificationsFromUser(int userId)
      {
         throw new NotImplementedException();
      }
      
      public void SendTo(int patientId, int doctorId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.NotificationService notificationService;
   
   }
}