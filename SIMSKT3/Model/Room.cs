
using System.Collections.Generic;

namespace Classes.Model
{
    public class Room
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int floor { get; set; }
        public string description { get; set; }
        public List<StaticEquipment> staticEquipment { get; set; }
        public string beds { get; set; }

        public Room(int id, string name, string type, int floor, string description, List<StaticEquipment> staticEquipment, string beds)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.floor = floor;
            this.description = description;
            if (staticEquipment == null)
            {
                this.staticEquipment = new List<StaticEquipment>();
            }
            else
                this.staticEquipment = staticEquipment;
            this.beds = beds;
        }

        public Room()
        {
            this.staticEquipment = new List<StaticEquipment>();
        }

    }
}