
using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Repository;
using Classes.Controller;
namespace Classes.Service
{
   public class RenovationService
   {
        RenovationRepository renovationRepository = new RenovationRepository();
        RoomController roomController = new RoomController();
        StaticEquipmentController staticController = new StaticEquipmentController();
        List<Room> pendingRooms = new List<Room>();
        private readonly Random _random = new Random();
      public string CreateRenovation(Renovation renovation)
      {
         return renovationRepository.CreateRenovation(renovation);
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
            return renovationRepository.ReadAllRenovations();
        }
        public void ExecuteRenovationAction()
        {
            renovationRepository.ExecuteRenovationAction();
        }

    }
}