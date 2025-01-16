using System;

namespace Classes.Model
{
    public class StaticEquipment
    {
        public StaticEquipment(string roomName, int id, string typeOdStaticEquipment, int quantity)
        {
            this.roomName = roomName;
            this.id = id;
            this.typeOdStaticEquipment = typeOdStaticEquipment;
            this.quantity = quantity;
        }

        public string roomName { get; set; }
        public int id { get; set; }
        public string typeOdStaticEquipment { get; set; }
        public int quantity { get; set; }
    }
}