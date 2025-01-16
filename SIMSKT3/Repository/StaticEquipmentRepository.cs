
using System;
using Classes.Model;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Classes.Repository
{
   public class StaticEquipmentRepository
   {
        public List<StaticEquipment> statics = new List<StaticEquipment>();
        //public List<ManageTransfer> manageTransfers = new List<ManageTransfer>();
        public List<Appointment> appointments = new List<Appointment>();
        public List<Room> rooms = new List<Room>();
        public StaticEquipmentRepository()
        {

            // deserijalizuje rooms.json
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
        }
        public void writeInJson()// sluzi za pisanje staticke u json fajl 
        {
            string json = JsonConvert.SerializeObject(statics, Formatting.Indented);
            File.WriteAllText("staticequipment.json", json);
        }
        RoomController roomController = new RoomController();
        public void CreateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
      {
            Room r1 = null;
            int i = 0; // sluzi kao flag da li postoji staticka oprema koja treba da bude kreirana
            foreach (var room in rooms)
            {
                if (room.name == staticEquip.roomName)
                {
                    foreach (var stat in room.staticEquipment.ToArray())
                    {
                        if (stat.typeOdStaticEquipment == staticEquip.typeOdStaticEquipment)
                        {
                            i = i + 1;
                        }
                    }
                }
            }

            // ako je i=0 onda oprema ne postoji i kreira se
            if (i == 0)
            {
                foreach (Room room in rooms)
                {
                    if (room.name == staticEquip.roomName)
                    {
                        r1 = room;
                        r1.staticEquipment.Add(staticEquip);
                        roomController.UpdateRoom(r1);
                        break;
                    }
                }
            }

            //// else znaci da postoji oprema i samo se kolicina dodaje na postojecu
            //// pri cemu index i naziv opreme koja se vec nalazila u jsonu
            else
            {
                foreach (Room room in rooms)
                {
                    if (room.name == staticEquip.roomName)
                    {
                        foreach (var sta in room.staticEquipment)
                        {
                            if (sta.typeOdStaticEquipment == staticEquip.typeOdStaticEquipment)
                            {
                                sta.quantity = sta.quantity + staticEquip.quantity;
                                r1 = room;
                                roomController.UpdateRoom(r1);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public List<StaticEquipment> ReadEquipmentByRoomName(string roomName)
        {
            List<StaticEquipment> statica = new List<StaticEquipment>();
            foreach (var room in rooms)
            {
                if (room.name == roomName)
                {
                    foreach (var stat in room.staticEquipment)
                    {
                        statica.Add(stat);
                    }
                }
            }
            return statica;
        }

        public void UpdateStaticEquipment(StaticEquipment staticEquip)
        {
            Room r1 = null;
            foreach (var room in rooms)
            {
                if (room.name == staticEquip.roomName)
                {
                    foreach (var sta in room.staticEquipment)
                    {
                        if (sta.id == staticEquip.id)
                        {
                            sta.typeOdStaticEquipment = staticEquip.typeOdStaticEquipment;
                            sta.quantity = staticEquip.quantity;
                            r1 = room;
                            roomController.UpdateRoom(r1);
                            break;
                        }
                    }
                }
            }
        }
      
      public void DeleteStaticEquipment(string roomName, int staticId)
      {
            Room r1 = null;
            foreach (var room in rooms)
            {
                if (room.name == roomName)
                {
                    foreach (var sta in room.staticEquipment)
                    {
                        if (sta.id == staticId)
                        {
                            room.staticEquipment.Remove(sta);
                            r1 = room;
                            roomController.UpdateRoom(r1);
                            break;
                        }
                    }
                }
            }
        }
      
      public List<StaticEquipment> ReadAllStaticEquipment()
      {
         throw new NotImplementedException();
      }
      
      public void TransferStaticEquipment(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CheckQuantity(int staticEquipId, double quantity)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}