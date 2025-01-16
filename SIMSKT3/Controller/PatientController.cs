// File:    PatientController.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 3:37:05 PM
// Purpose: Definition of Class PatientController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class PatientController
   {
      public Classes.Model.Patient CreatePatient(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient ReadPatient(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient UpdatePatient(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void DeletePatient(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public List<Patient> GetAllPatients()
      {
         throw new NotImplementedException();
      }
      
      public void deleteAll()
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgValid(string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgUnique(string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
      {
         throw new NotImplementedException();
      }
      
      public int IncreaseCancellationCounter(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public int GetNumberOfCancellations(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public bool GetPatientStatus(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public bool CheckForNotifications(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.PatientService patientService;
   
   }
}