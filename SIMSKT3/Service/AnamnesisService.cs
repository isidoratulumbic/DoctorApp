// File:    AnamnesisService.cs
// Author:  LENOVO
// Created: Wednesday, May 19, 2021 10:00:53
// Purpose: Definition of Class AnamnesisService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class AnamnesisService
   {
        Classes.Repository.AnamnesisRepository anamnesisRepository = new Classes.Repository.AnamnesisRepository();
      public void CreateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
            anamnesisRepository.CreateAnamnesis(anamnesis);
      }
      
      public void UpdateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
            anamnesisRepository.UpdateAnamnesis(anamnesis);
        }

      public List<Classes.Model.Anamnesis> GetAnamnesisByPatientJmbg(string patientJmbg)
      {
         return anamnesisRepository.GetAnamnesisByPatientJmbg(patientJmbg);
      }

       // public Classes.Repository.AnamnesisRepository anamnesisRepository;
   
   }
}