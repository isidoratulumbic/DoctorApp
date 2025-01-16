using System;

namespace Classes.Model
{
   public class Appointment
   {
        public int id { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateTime date { get; set; }
        public string roomName { get; set; }
        public string appointmentType { get; set; }

        public bool isEmergency = false;
        public string doctorJmbg { get; set; }
        public string doctorSpecialization { get; set; }
        public string patientJmbg { get; set; }
        public string available { get; set; }

        public string dr { get; set; }

        public string doctorName { get; set; }


        public Appointment(int id, string appointmentType, DateTime startTime, DateTime endTime, DateTime date, string patientJmbg, string doctorJmbg,string dr, string roomName, bool isEmergency)
        {
            this.id = id;
            this.appointmentType = appointmentType;
            this.startTime = startTime;
            this.endTime = endTime;
            this.date = date;
            this.patientJmbg = patientJmbg;
            this.doctorJmbg = doctorJmbg;
            this.dr = dr;
            this.roomName = roomName;
            this.isEmergency = isEmergency;
        }

      
        public Patient patient;

       
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
                  oldPatient.RemoveAppointment(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddAppointment(this);
               }
            }
         }
      }
      public Secretary secretary;
      
      
      public Secretary Secretary
      {
         get
         {
            return secretary;
         }
         set
         {
            if (this.secretary == null || !this.secretary.Equals(value))
            {
               if (this.secretary != null)
               {
                  Secretary oldSecretary = this.secretary;
                  this.secretary = null;
                  oldSecretary.RemoveAppointment(this);
               }
               if (value != null)
               {
                  this.secretary = value;
                  this.secretary.AddAppointment(this);
               }
            }
         }
      }
      public Doctor doctor;
      
      
      //public Doctor Doctor
      //{
      //   get
      //   {
      //      return doctor;
      //   }
      //   set
      //   {
      //      if (this.doctor == null || !this.doctor.Equals(value))
      //      {
      //         if (this.doctor != null)
      //         {
      //            Doctor oldDoctor = this.doctor;
      //            this.doctor = null;
      //            oldDoctor.RemoveAppointment(this);
      //         }
      //         if (value != null)
      //         {
      //            this.doctor = value;
      //            this.doctor.AddAppointment(this);
      //         }
      //      }
      //   }
      //}
      public Employee employee;
      
     
      //public Employee Employee
      //{
      //   get
      //   {
      //      return employee;
      //   }
      //   set
      //   {
      //      if (this.employee == null || !this.employee.Equals(value))
      //      {
      //         if (this.employee != null)
      //         {
      //            Employee oldEmployee = this.employee;
      //            this.employee = null;
      //            oldEmployee.RemoveAppointment(this);
      //         }
      //         if (value != null)
      //         {
      //            this.employee = value;
      //            this.employee.AddAppointment(this);
      //         }
      //      }
      //   }
      //}
   
   }
}