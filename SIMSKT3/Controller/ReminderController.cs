// File:    ReminderController.cs
// Author:  HP-Miha
// Created: Sunday, May 16, 2021 9:55:51 PM
// Purpose: Definition of Class ReminderController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class ReminderController
   {
      public Reminder CreateReminder(Reminder reminder)
      {
            return reminderService.CreateReminder(reminder);
        }
      
      public Reminder UpdateReminder(Reminder reminder)
      {
            return reminderService.UpdateReminder(reminder);
        }
      
      public Reminder ReadReminder(int reminderId)
      {
            return reminderService.ReadReminder(reminderId);
        }
      
      public void DeleteReminder(int reminderId)
      {
            reminderService.DeleteReminder(reminderId);
        }
      
      public List<Reminder> ReadAllReminders()
      {
            return reminderService.ReadAllReminders();
        }
      
      public Classes.Service.ReminderService reminderService;
   
   }
}