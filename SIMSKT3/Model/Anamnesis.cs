// File:    Anamnesis.cs
// Author:  HP-Miha
// Created: Thursday, April 8, 2021 7:20:32 PM
// Purpose: Definition of Class Anamnesis

using System;

namespace Classes.Model
{
   public class Anamnesis
   {
        public int id { get; set; }
        public string name { get; set; }

        public DateTime date { get; set; }
        public string description { get; set; }
        public string patientJmbg { get; set; }

        public Anamnesis(int id, string patientJmbg, string name, DateTime date, string description)
        {
            this.id = id;
            this.patientJmbg = patientJmbg;
            this.name = name;
            this.date = date;
            this.description = description;
        }

        public MedicalRecord medicalRecord;
   
   }
}