
using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Service;

namespace Classes.Controller
{
   public class StaticEquipmentController
   {
      StaticEquipmentService staticService = new StaticEquipmentService();
      public void CreateStaticEquipment(StaticEquipment staticEquip)
      {
          staticService.CreateStaticEquipment(staticEquip);
      }
        public List<StaticEquipment> ReadEquipmentByRoomName(string roomName)
        {
            return staticService.ReadEquipmentByRoomName(roomName);
        }
        public StaticEquipment ReadStaticEquipment(int id)
      {
         throw new NotImplementedException();
      }
      
      public void UpdateStaticEquipment(StaticEquipment staticEquip)
      {
         staticService.UpdateStaticEquipment(staticEquip);
      }
      
      public void DeleteStaticEquipment(string roomName, int staticId)
      {
         staticService.DeleteStaticEquipment(roomName, staticId);
      }
      
      public List<StaticEquipment> ReadAllStaticEquipment()
      {
         throw new NotImplementedException();
      }
      
      public void TransferStaticEquipment(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
      {
        //todo
      }
   }
}