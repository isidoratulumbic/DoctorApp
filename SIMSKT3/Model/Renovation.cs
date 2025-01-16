
using System;
using System.Collections.Generic;
namespace Classes.Model
{
    public class Renovation
    {
        public string roomName { get; set; }
        public List<string> roomsIncluded { get; set; }
        public string actionType { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string description { get; set; }

        public Renovation(string roomName, List<string> roomsIncluded, string actionType, DateTime date, DateTime startTime, DateTime endTime, string description)
        {
            this.roomName = roomName;
            this.roomsIncluded = roomsIncluded;
            this.actionType = actionType;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.description = description;
        }
    }
}