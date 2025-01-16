
using System;
using Classes.Model;
using Classes.Repository;
using System.Collections.Generic;

namespace Classes.Service
{
   public class StaticEquipmentService
   {
        StaticEquipmentRepository staticRepository = new StaticEquipmentRepository();
        public void CreateStaticEquipment(StaticEquipment staticEquip)
        {
            staticRepository.CreateStaticEquipment(staticEquip);
        }
        public List<StaticEquipment> ReadEquipmentByRoomName(string roomName)
        {
            return staticRepository.ReadEquipmentByRoomName(roomName);
        }
        public StaticEquipment ReadStaticEquipment(int id)
      {
         throw new NotImplementedException();
      }
      
      public void UpdateStaticEquipment(StaticEquipment staticEquip)
      {
         staticRepository.UpdateStaticEquipment(staticEquip);
      }
      
      public void DeleteStaticEquipment(string roomName, int staticId)
      {
         staticRepository.DeleteStaticEquipment(roomName, staticId);
      }
      
      public List<StaticEquipment> ReadAllStaticEquipment()
      {
         throw new NotImplementedException();
      }
      
      public void TransferStaticEquipment(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CheckDate(DateTime transferDate)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CheckToTransfer(DateTime transferDate)
      {
         throw new NotImplementedException();
      }
      
      public bool ClaimTransfer()
      {
         throw new NotImplementedException();
      }
      
      public void TransferSuccessfull(string notification)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CheckQuantity(int staticEquipId, double quantity)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.StaticEquipmentRepository staticEquipmentRepository;
   
   }
}