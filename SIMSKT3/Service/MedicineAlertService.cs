// File:    MedicineAlertService.cs
// Author:  HP-Miha
// Created: Sunday, April 18, 2021 8:12:47 PM
// Purpose: Definition of Class MedicineAlertService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class MedicineAlertService
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
      
      public Classes.Repository.MedicineAlertRepository medicineAlertRepository;
   
   }
}