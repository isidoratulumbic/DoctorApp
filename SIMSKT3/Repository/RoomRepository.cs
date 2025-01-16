
using System;
using System.Collections.Generic;
using System.IO;
using Classes.Model;
using Newtonsoft.Json;

namespace Classes.Repository
{
   public class RoomRepository
   {
      public List<Room> rooms = new List<Room>();
      public List<Room> pendingRooms = new List<Room>();
        public RoomRepository()
        {
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
            //otvara pendingRoom json
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

        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(rooms, Formatting.Indented);
            File.WriteAllText("rooms.json", json);
        }
        public void writePendingJson()
        {
            string json = JsonConvert.SerializeObject(pendingRooms, Formatting.Indented);
            File.WriteAllText("pendingRoom.json", json);
        }
        public void CreateRoom(Room room)
        {
            rooms.Add(room);
            writeInJson();
        }
        public void CreatePendingRoom(Room room)
        {
            pendingRooms.Add(room);
            writePendingJson();
        }
        public Room ReadRoomById(int id)
        {
            Room r = null;
            foreach (var rum in rooms)
            {
                if (rum.id == id)
                {
                    r = rum;
                    break;
                }
            }
            return r;
        }
        public Room ReadRoomByName(string roomName)
        {
            Room r = null;
            foreach (var room in rooms)
            {
                if (room.name == roomName)
                {
                    r = room;
                    break;
                }
            }
            return r;
        }
        public void UpdateRoom(Room room)
      {
            int index = rooms.FindIndex(obj => obj.id == room.id);
            rooms[index] = room;
            writeInJson();
        }
      
      public void DeleteRoomById(int id)
      {
            foreach (var room in rooms.ToArray())
            {
                if (room.id == id)
                {
                    rooms.Remove(room);
                    writeInJson();
                }
            }
        }
        public void DeleteRoomByName(string roomName)
        {
            foreach (var room in rooms.ToArray())
            {
                if (room.name == roomName)
                {
                    rooms.Remove(room);
                    writeInJson();
                }
            }
        }
      public List<Room> ReadAllRooms()
      {
         return rooms;
      }
      
      public void MergeRooms(List<Room> RoomsForMerge)
      {
         throw new NotImplementedException();
      }
      
      public void SplitRoom(Classes.Model.Room roomForSplit, int numberOfSplits)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}