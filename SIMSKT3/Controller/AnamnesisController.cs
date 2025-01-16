using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class AnamnesisController
   {
        Classes.Service.AnamnesisService anamnesisService = new Classes.Service.AnamnesisService();
      public void CreateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
            anamnesisService.CreateAnamnesis(anamnesis);
      }
      
      public void UpdateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
            anamnesisService.UpdateAnamnesis(anamnesis);
        }

      public List<Anamnesis> GetAnamnesisByPatientJmbg(String patientJmbg)
      {
         return anamnesisService.GetAnamnesisByPatientJmbg(patientJmbg);
      }   
   }
}