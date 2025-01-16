// File:    MedicalRecordRepository.cs
// Author:  LENOVO
// Created: Friday, April 16, 2021 2:36:27 PM
// Purpose: Definition of Class MedicalRecordRepository

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Repository
{
   public class MedicalRecordRepository
   {
      public int CreateMedicalRecord(Classes.Model.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.MedicalRecord UpdateMedicalRecord(Classes.Model.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.MedicalRecord GetMedicalRecordById(int id)
      {
         throw new NotImplementedException();
      }
      
      public void removeMR(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalRecord> GetAllMedicalRecords()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen AddNewAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen UpdateAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public List<Allergen> GetAllAlergens(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Prescription AddPrescription(int id, string medicine, string usage, string quantity)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Prescription GetPrescriptionById(int prescriptionId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Anamnesis CreateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Anamnesis UpdateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}