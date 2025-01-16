// File:    ReminderService.cs
// Author:  HP-Miha
// Created: Sunday, May 16, 2021 10:04:47 PM
// Purpose: Definition of Class ReminderService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class ReminderService
   {
        public List<Reminder> reminders = new List<Reminder>();
        public Reminder CreateReminder(Reminder reminder)
      {
            return reminderRepository.CreateReminder(reminder);
      }
      
      public Reminder UpdateReminder(Reminder reminder)
      {
            return reminderRepository.UpdateReminder(reminder);
        }
      
      public Reminder ReadReminder(int reminderId)
      {
            return reminderRepository.ReadReminder(reminderId);
        }
      
      public void DeleteReminder(int reminderId)
      {
            reminderRepository.DeleteReminder(reminderId);
        }
      
      public List<Reminder> ReadAllReminders()
      {
            return reminderRepository.ReadAllReminders();
        }
      
      public Classes.Repository.ReminderRepository reminderRepository;
   
   }
}