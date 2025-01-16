// File:    MedicineAlertRepository.cs
// Author:  HP-Miha
// Created: Saturday, April 17, 2021 11:49:52 PM
// Purpose: Definition of Class MedicineAlertRepository

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Repository
{
   public class MedicineAlertRepository
   {
      public MedicineAlert ReadMedicineAlert(int medicineAlertId)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicineAlert> ReadAllMedicineAlerts(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public void deleteReminder(int medicineAlertId)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}