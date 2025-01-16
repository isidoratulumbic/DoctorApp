
using System;
using Classes.Model;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Classes.Repository
{
   public class RenovationRepository
   {
        public List<Renovation> renovations = new List<Renovation>();
        public List<Appointment> appointments = new List<Appointment>();
        RoomController roomController = new RoomController();
        List<Room> pendingRooms = new List<Room>();
        List<Room> rooms = new List<Room>();
        public RenovationRepository()
        {
            // deserializuje renovation.json
            if (!File.Exists("renovation.json"))
            {
                File.Create("renovation.json").Close();
            }

            using (StreamReader r = new StreamReader("renovation.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    renovations = JsonConvert.DeserializeObject<List<Renovation>>(json);
                }
            }

            // deserializuje renovation.json
            if (!File.Exists("rooms.json"))
            {
                File.Create("rooms.json").Close();
            }

            using (StreamReader r = new StreamReader("rooms.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    rooms = JsonConvert.DeserializeObject<List<Room>>(json);
                }
            }

            // deserializuje pendingRoom.json
            if (!File.Exists("pendingRoom.json"))
            {
                File.Create("pendingRoom.json").Close();
            }

            using (StreamReader r = new StreamReader("pendingRoom.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    pendingRooms = JsonConvert.DeserializeObject<List<Room>>(json);
                }
            }

            // deserializuje appointment.json
            if (!File.Exists("appointment.json"))
            {
                File.Create("appointment.json").Close();
            }

            using (StreamReader r = new StreamReader("appointment.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(renovations, Formatting.Indented);
            File.WriteAllText("renovation.json", json);
        }

        public string CreateRenovation(Renovation renovation)
        {
            string message = " "; //flag za gresku

            if (CheckIfDateIsOK(renovation) == false)
                return message = "Unet je los datum!";

            else
            {
                if (isAdvancedRenovation(renovation))
                {
                    renovations.Add(renovation);
                    writeInJson();
                    return message = "Renoviranje je zakazano uspesno";
                }
                else
                {
                    if (CheckIfTermIsAvailable(renovation) == false)
                        return message = "Unet je termin u kojem je vec zakazan pregled";
                    else
                    {
                        renovations.Add(renovation);
                        writeInJson();
                        return message = "Renoviranje je zakazano uspesno";
                    }
                }
            }
            return message;
        }
        public bool isAdvancedRenovation(Renovation renovation)
        {
            bool isAdvanced = false;
            if (renovation.actionType != null) isAdvanced = true;
            return isAdvanced;

        }
        public bool CheckIfDateIsOK(Renovation renovation)
        {
            bool isDateOK = true;

            if (renovation.date.Date < DateTime.Now.Date) isDateOK = false;
            if (renovation.startTime > renovation.endTime) isDateOK = false;

            return isDateOK;
        }

        public bool CheckIfTermIsAvailable(Renovation renovation)
        {
            string start = renovation.startTime.ToString("HH:mm");
            string end = renovation.endTime.ToString("HH:mm");
            string enterdate = renovation.date.ToString("M/dd/yyyy");

            bool isAvailable = true;            // flag da li je slobodan termin

            // proverava da li je ovaj termin vec zauzet u appointmentima
            foreach (var apps in appointments)
            {
                if (apps.roomName.Equals(renovation.roomName) && apps.date.Date == renovation.date.Date)
                {
                    string appstart = apps.startTime.ToString("HH:mm"); // stavlja se u isti format kao i start da bi moglo da se uporedi sa njim
                    string append = apps.endTime.ToString("HH:mm");     // stavlja se u isti format kao i end da bi moglo da se uporedi sa njim
                    if (appstart.Equals(start))
                    {
                        isAvailable = false;
                    }
                }
            }

            return isAvailable;
        }
        public Renovation ReadRenovation(int renovationId)
      {
         throw new NotImplementedException();
      }
      
      public void UpdateRenovation(Renovation renovation)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteRenovationById(Renovation renovation)
      {
         throw new NotImplementedException();
      }
      
      public List<Renovation> ReadAllRenovations()
      {
            return renovations;
      }
       
        public void ExecuteRenovationAction()
        {
            DateTime date = DateTime.Now;
            bool actualRoomIsRenovated = false;
            foreach (var renovation in renovations)
            {
                if (renovation.startTime < date)
                {
                    foreach (var pendingRoom in pendingRooms.ToArray())
                    {
                        if (renovation.roomsIncluded == null) continue;
                        foreach (var includedRoom in renovation.roomsIncluded)
                        {
                            if (includedRoom == pendingRoom.name)
                            {
                                roomController.CreateRoom(pendingRoom);
                                pendingRooms.Remove(pendingRoom);
                                string json = JsonConvert.SerializeObject(pendingRooms, Formatting.Indented);
                                File.WriteAllText("pendingRoom.json", json);
                                actualRoomIsRenovated = true;
                            }
                        }
                        if (actualRoomIsRenovated)
                        {
                            roomController.DeleteRoomByName(renovation.roomName);
                            actualRoomIsRenovated = false;
                        }

                    }
                }
            }
        }
    }
}