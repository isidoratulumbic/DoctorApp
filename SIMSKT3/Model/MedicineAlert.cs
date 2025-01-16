// File:    MedicineAlert.cs
// Author:  HP-Miha
// Created: Sunday, April 18, 2021 7:59:14 PM
// Purpose: Definition of Class MedicineAlert

using System;

namespace Classes.Model
{
   public class MedicineAlert
   {
      public int id;
      public string name;
      public string description;
      public DateTime alarmTime;
      
      public Prescription prescription;
      public Patient patient;
      
      /// <summary>
      /// Property for Patient
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Patient Patient
      {
         get
         {
            return patient;
         }
         set
         {
            if (this.patient == null || !this.patient.Equals(value))
            {
               if (this.patient != null)
               {
                  Patient oldPatient = this.patient;
                  this.patient = null;
                  oldPatient.RemoveMedicineAlert(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddMedicineAlert(this);
               }
            }
         }
      }
   
   }
}