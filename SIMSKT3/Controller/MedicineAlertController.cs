// File:    MedicineAlertController.cs
// Author:  HP-Miha
// Created: Sunday, April 18, 2021 8:14:41 PM
// Purpose: Definition of Class MedicineAlertController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class MedicineAlertController
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
      
      public Classes.Service.MedicineAlertService medicineAlertService;
   
   }
}