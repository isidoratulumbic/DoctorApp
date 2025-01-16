using System;
using System.Collections.Generic;
using System.IO;
using Classes.Model;
using Newtonsoft.Json;

namespace Classes.Service
{
   public class AppointmentService
   {
        List<Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointments.json"));
        Classes.Repository.AppointmentRepository appointmentRepository = new Classes.Repository.AppointmentRepository();
        public Classes.Repository.RoomRepository roomRepository;
        List<Renovation> renovations = JsonConvert.DeserializeObject<List<Classes.Model.Renovation>>(File.ReadAllText("renovation.json"));


        public void CreateAppointment(Classes.Model.Appointment appointment)
        {
            appointmentRepository.CreateAppointment(appointment);
        }

        public Classes.Model.Appointment ReadAppointment(int id)
        {
            return appointmentRepository.ReadAppointment(id);
        }

        public void UpdateAppointment(Classes.Model.Appointment appointment)
        {
            appointmentRepository.UpdateAppointment(appointment);
        }
        

        public bool CheckUniqueInput(Classes.Model.Appointment appointment)
        {
            foreach (var app in appointments)
            {
                if (appointment.startTime == app.startTime && appointment.endTime == app.endTime && appointment.date == app.date ||
                    appointment.startTime == app.startTime && appointment.date == app.date ||
                    appointment.endTime == app.endTime && appointment.date == app.date)
                {
                    //The appointment is busy! Change time!
                    return false;
                }

            }
            return true;
        }

        public bool CheckUniqueId(Classes.Model.Appointment appointment)
        {
            List<Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointments.json"));
            foreach (var ht in appointments)
            {
                if (ht.id == Convert.ToInt32(appointment.id))
                {
                    //MessageBox.Show("ID already exist!");
                    return true;
                }

            }
            return false;
        }

        public void DeleteAppointment(int appointmentId)
        {  
            appointmentRepository.DeleteAppointment(appointmentId);
        }
      
      public List<Appointment> readAllAppointments()
      {
           return appointmentRepository.readAllAppointments();
      }
      
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> ReadDoctorAppointments(string doctorJmbg)
      {
            return appointmentRepository.ReadDoctorAppointments(doctorJmbg);
      }
      
      public List<Appointment> ReadPatientAppointments(string patientJmbg)
      {
          return appointmentRepository.ReadPatientAppointments(patientJmbg);
      }

        public bool CheckForInvalidInput(Classes.Model.Appointment appointment)
        {
            try
            {
                if (appointment.date <= DateTime.Now)
                {
                    return true;
                }
                else
                if (appointment.startTime.Hour > appointment.endTime.Hour)
                {
                    //End time must be after start time
                    return true;
                }
                else if (appointment.startTime.Hour == appointment.endTime.Hour)
                {
                    if (appointment.startTime.Minute > appointment.endTime.Minute)
                    {
                        //End time must be after start time
                        return true;
                    }
                }

            }
            catch (Exception)
            {
                //Time is not in valid format
                return true;
            }
            return false;
        }

        public bool AppointmentBusyByRenovation(Classes.Model.Appointment appointment)
        {
            foreach (var ren in renovations)
            {
                string[] appRoom = appointment.roomName.Split(' ');

                if (appRoom[0].Equals(ren.roomName) && appointment.startTime.Hour == ren.startTime.Hour && appointment.startTime.Minute == ren.startTime.Minute && appointment.endTime.Hour == ren.endTime.Hour && appointment.endTime.Minute == ren.endTime.Minute && appointment.date == ren.date ||
                    appRoom[0].Equals(ren.roomName) && appointment.startTime.Hour == ren.startTime.Hour && appointment.startTime.Minute == ren.startTime.Minute && appointment.date == ren.date ||
                    appRoom[0].Equals(ren.roomName) && appointment.endTime.Hour == ren.endTime.Hour && appointment.endTime.Minute == ren.endTime.Minute && appointment.date == ren.date)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AppointmentBusy(Classes.Model.Appointment apointment)
        {
            foreach (var app in appointments)
            {
                if (apointment.startTime.Hour == app.startTime.Hour && apointment.startTime.Minute == app.startTime.Minute && apointment.endTime.Hour == app.endTime.Hour && apointment.endTime.Minute == app.endTime.Minute && apointment.date == app.date ||
                    apointment.startTime.Hour == app.startTime.Hour && apointment.startTime.Minute == app.startTime.Minute && apointment.date == app.date ||
                    apointment.endTime.Hour == app.endTime.Hour && apointment.endTime.Minute == app.endTime.Minute && apointment.date == app.date)
                {
                    //"The appointment is busy! Change time!");
                    return true;
                }
            }
            return false;
        }

    }
}