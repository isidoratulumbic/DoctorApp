// File:    AllergenWarning.cs
// Author:  LifeBook A574
// Created: Wednesday, May 12, 2021 9:19:59 AM
// Purpose: Definition of Class AllergenWarning

using System;

namespace Classes.Model
{
   public class AllergenWarning
   {
      public int id;
      public string alergenName;
      public string warningMessage;
      
      public Prescription prescription;
      public Allergen allergen;
   
   }
}