// File:    Secretary.cs
// Author:  LENOVO
// Created: Monday, April 12, 2021 8:55:41 PM
// Purpose: Definition of Class Secretary

using System;

namespace Classes.Model
{
   public class Secretary : Employee
   {
      public System.Collections.Generic.List<MedicalRecord> medicalRecord;
      
      /// <summary>
      /// Property for collection of MedicalRecord
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<MedicalRecord> MedicalRecord
      {
         get
         {
            if (medicalRecord == null)
               medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
            return medicalRecord;
         }
         set
         {
            RemoveAllMedicalRecord();
            if (value != null)
            {
               foreach (MedicalRecord oMedicalRecord in value)
                  AddMedicalRecord(oMedicalRecord);
            }
         }
      }
      
      /// <summary>
      /// Add a new MedicalRecord in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicalRecord(MedicalRecord newMedicalRecord)
      {
         if (newMedicalRecord == null)
            return;
         if (this.medicalRecord == null)
            this.medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
         if (!this.medicalRecord.Contains(newMedicalRecord))
            this.medicalRecord.Add(newMedicalRecord);
      }
      
      /// <summary>
      /// Remove an existing MedicalRecord from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicalRecord(MedicalRecord oldMedicalRecord)
      {
         if (oldMedicalRecord == null)
            return;
         if (this.medicalRecord != null)
            if (this.medicalRecord.Contains(oldMedicalRecord))
               this.medicalRecord.Remove(oldMedicalRecord);
      }
      
      /// <summary>
      /// Remove all instances of MedicalRecord from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicalRecord()
      {
         if (medicalRecord != null)
            medicalRecord.Clear();
      }
      public System.Collections.Generic.List<Appointment> appointment;
      
      /// <summary>
      /// Property for collection of Appointment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Appointment> Appointment
      {
         get
         {
            if (appointment == null)
               appointment = new System.Collections.Generic.List<Appointment>();
            return appointment;
         }
         set
         {
            RemoveAllAppointment();
            if (value != null)
            {
               foreach (Appointment oAppointment in value)
                  AddAppointment(oAppointment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Appointment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAppointment(Appointment newAppointment)
      {
         if (newAppointment == null)
            return;
         if (this.appointment == null)
            this.appointment = new System.Collections.Generic.List<Appointment>();
         if (!this.appointment.Contains(newAppointment))
         {
            this.appointment.Add(newAppointment);
            newAppointment.Secretary = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Appointment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAppointment(Appointment oldAppointment)
      {
         if (oldAppointment == null)
            return;
         if (this.appointment != null)
            if (this.appointment.Contains(oldAppointment))
            {
               this.appointment.Remove(oldAppointment);
               oldAppointment.Secretary = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Appointment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAppointment()
      {
         if (appointment != null)
         {
            System.Collections.ArrayList tmpAppointment = new System.Collections.ArrayList();
            foreach (Appointment oldAppointment in appointment)
               tmpAppointment.Add(oldAppointment);
            appointment.Clear();
            foreach (Appointment oldAppointment in tmpAppointment)
               oldAppointment.Secretary = null;
            tmpAppointment.Clear();
         }
      }
   
   }
}