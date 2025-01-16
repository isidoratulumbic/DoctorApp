// File:    ReferralLetterForSpecialist.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 5:09:31 PM
// Purpose: Definition of Class ReferralLetterForSpecialist

using System;

namespace Classes.Model
{
   public class ReferralLetterForSpecialist
   {
        public int id { get; set; }
        public string reason { get; set; }
        public bool isUsed { get; set; }
        public string patientJmbg { get; set; }
        public string type { get; set; }
        public string doctorr { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        



        public ReferralLetterForSpecialist(int id ,string patientJmbg, string doctorr, string reason, string type, DateTime startTime, DateTime endTime, DateTime date)
        {
            this.id = id;
            this.patientJmbg = patientJmbg;
            this.doctorr = doctorr;
            this.reason = reason;
            this.type = type;
            this.startTime = startTime;
            this.endTime = endTime;
            this.date = date;
        }

        public Doctor doctor;
      public string doctorJmbg;
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
                  oldPatient.RemoveReferralLetterForSpecialist(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddReferralLetterForSpecialist(this);
               }
            }
         }
      }
   
   }
}