// File:    GuestAccountRepository.cs
// Author:  LENOVO
// Created: Friday, April 30, 2021 12:02:15 PM
// Purpose: Definition of Class GuestAccountRepository

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Repository
{
   public class GuestAccountRepository
   {
      public List<Patient> GetAllGuests()
      {
         throw new NotImplementedException();
      }
      
      public void SaveGuest(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Patient UpdateGuest(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void removePAcc(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient CreateGuest(int patientId, string name, string surname, string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetGuestByJMBG(int jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetGuestById(int id)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}