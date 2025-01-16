using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class AppointmentController
   {
        public List<Appointment> appointments = new List<Appointment>();
        Classes.Service.AppointmentService appointmentService = new Classes.Service.AppointmentService();

        public void CreateAppointment(Classes.Model.Appointment appointment)
        {
             appointmentService.CreateAppointment(appointment);
        }

        public Classes.Model.Appointment ReadAppointment(int id)
        {
            return appointmentService.ReadAppointment(id);
        }

        public void UpdateAppointment(Classes.Model.Appointment appointment)
        {
             appointmentService.UpdateAppointment(appointment);
        }
        

        public void DeleteAppointment(int appointmentId)
        {
             appointmentService.DeleteAppointment(appointmentId);
        }

        public List<Appointment> readAllAppointments()
        {
            return appointmentService.readAllAppointments();
        }

        public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
        {
             throw new NotImplementedException();
        }
      
        public List<Appointment> ReadDoctorAppointments(string doctorJmbg)
        {
            return appointmentService.ReadDoctorAppointments(doctorJmbg);

        }

        public List<Appointment> ReadPatientAppointments(string patientJmbg)
        {
            return appointmentService.ReadPatientAppointments(patientJmbg);
        }

        public bool CheckUniqueInput(Classes.Model.Appointment appointment) 
        {
            return appointmentService.CheckUniqueInput(appointment);
        }

        public bool CheckForInvalidInput(Classes.Model.Appointment appointment)
        {
            return appointmentService.CheckForInvalidInput(appointment);
        }

        public bool CheckUniqueId(Classes.Model.Appointment appointment)
        {
            return appointmentService.CheckUniqueId(appointment);
        }

        public bool AppointmentBusyByRenovation(Classes.Model.Appointment appointment)
        {
            return appointmentService.AppointmentBusyByRenovation(appointment);
        }

        public bool AppointmentBusy(Classes.Model.Appointment appointment)
        {
            return appointmentService.AppointmentBusy(appointment);
        }
        


    }
}