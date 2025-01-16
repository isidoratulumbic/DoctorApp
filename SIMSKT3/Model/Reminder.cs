// File:    Reminder.cs
// Author:  HP-Miha
// Created: Sunday, May 16, 2021 9:41:01 PM
// Purpose: Definition of Class Reminder

using System;

namespace Classes.Model
{
   public class Reminder
   {
        public int id { get; set; }
      public string name { get; set; }
        public string description { get; set; }
        public DateTime timeOfReminding { get; set; }
        public int periodOfReminding { get; set; }

        public Reminder(int id, string name, string description, DateTime timeOfReminding, int periodOfReminding)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.timeOfReminding = timeOfReminding;
            this.periodOfReminding = periodOfReminding;
        }

    }
}