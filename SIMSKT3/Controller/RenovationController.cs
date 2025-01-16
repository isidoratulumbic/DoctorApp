
using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Service;

namespace Classes.Controller
{
   public class RenovationController
   {
        RenovationService renovationService = new RenovationService();
        public string CreateRenovation(Renovation renovation)
      {
         return renovationService.CreateRenovation(renovation);
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
         return renovationService.ReadAllRenovations();
      }
      public void ExecuteRenovationAction()
      {
         renovationService.ExecuteRenovationAction();
      }
    }
}