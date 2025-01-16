// File:    Survey.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 5:46:30 PM
// Purpose: Definition of Class Survey

using System;

namespace Classes.Model
{
   public class Survey
   {
      public int id { get; set; }
        public int review { get; set; }
        public string description { get; set; }
        public string doctorr { get; set; }

        public Doctor doctor;
      public Patient patient;

        public Survey(int id, int review, string description, string doctor)
        {
            this.id = id;
            this.review = review;
            this.description = description;
            this.doctorr = doctor;
        }

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
                  oldPatient.RemoveSurvey(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddSurvey(this);
               }
            }
         }
      }
   
   }
}