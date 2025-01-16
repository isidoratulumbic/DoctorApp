// File:    HospitalTreatment.cs
// Author:  LifeBook A574
// Created: Wednesday, May 12, 2021 9:38:21 AM
// Purpose: Definition of Class HospitalTreatment

using System;

namespace Classes.Model
{
   public class HospitalTreatment
   {
        public int id { get; set; }
        public string room { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string patientJmbg { get; set; }
        public bool isExtensionNeeded = false;
        public string bed { get; set; }

        public HospitalTreatment(int id, string patientJmbg, DateTime startDate, DateTime endDate, string room, string bed)
        {
            this.id = id;
            this.room = room;
            this.startDate = startDate;
            this.endDate = endDate;
            this.patientJmbg = patientJmbg;
            this.bed = bed;
            //this.isExtensionNeeded = isExtensionNeeded;
        }

        public Patient patient;
   
   }
}