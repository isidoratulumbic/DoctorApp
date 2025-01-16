// File:    AllergenWarningService.cs
// Author:  LifeBook A574
// Created: Wednesday, May 12, 2021 10:38:10 AM
// Purpose: Definition of Class AllergenWarningService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class AllergenWarningService
   {
      public AllergenWarning CreateAllergenWarning(AllergenWarning allergenWarning)
      {
         throw new NotImplementedException();
      }
      
      public AllergenWarning ReadAllergenWarning(int allergenWarningId)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAllergenWarning(int allergenWarningId)
      {
         throw new NotImplementedException();
      }
      
      public List<AllergenWarning> ReadAllAllergenWarnings()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.AllergenWarningRepository allergenWarningRepository;
   
   }
}