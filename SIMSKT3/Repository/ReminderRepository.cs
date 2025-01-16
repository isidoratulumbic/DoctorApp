using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Classes.Repository
{
   public class ReminderRepository
   {
        public List<Reminder> reminders = new List<Reminder>();

        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(reminders, Formatting.Indented);
            File.WriteAllText("reminders.json", json);
        }

        public void ReadJson()
        {
            if (!File.Exists("reminders.json"))
            {
                File.Create("reminders.json").Close();
            }

            using (StreamReader r = new StreamReader("reminders.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    reminders = JsonConvert.DeserializeObject<List<Reminder>>(json);
                }
            }
        }

        public ReminderRepository()
        {
            ReadJson();
        }
        public Reminder CreateReminder(Reminder reminder)
      {
            ReadJson();

            reminders.Add(reminder);
            writeInJson();
            return reminder;
        }
      
      public Reminder UpdateReminder(Reminder reminder)
      {
            ReadJson();
            int index = reminders.FindIndex(obj => obj.id == reminder.id);
            reminders[index] = reminder;
            writeInJson();
            return reminder;
        }
      
      public Reminder ReadReminder(int reminderId)
      {
            ReadJson();
            return reminders.Find(obj => obj.id == reminderId);
        }
      
      public void DeleteReminder(int reminderId)
      {
            ReadJson();

            foreach (var ap in reminders.ToArray())
            {
                if (ap.id == reminderId)
                {
                    reminders.Remove(ap);
                    writeInJson();
                }
            }
        }
      
      public List<Reminder> ReadAllReminders()
      {
            ReadJson();
            return reminders;
        }
   
   }
}