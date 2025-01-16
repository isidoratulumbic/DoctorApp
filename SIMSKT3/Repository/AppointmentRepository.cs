using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Classes.Model;
using Newtonsoft.Json;

namespace Classes.Repository
{
   public class AppointmentRepository
   {

        List<Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointments.json"));

        public AppointmentRepository()
        {
            ReadJson();
        }


        public void ReadJson()
        {
            if (!File.Exists("appointments.json"))
            {
                File.Create("appointments.json").Close();
            }

            using (StreamReader r = new StreamReader("appointments.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }
            }
        }


        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
            File.WriteAllText("appointments.json", json);
        }

        public int GenerateId()
        {
            try
            {
                int maxId = appointments.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }

        public void CreateAppointment(Classes.Model.Appointment appointment)
        {
            ReadJson();
            int Id = GenerateId();
            appointment.id = Id;
            appointments.Add(appointment);
            writeInJson();            
        }

        public Classes.Model.Appointment ReadAppointment(int id)
        {
            ReadJson();
            return appointments.Find(obj => obj.id == id);

        }

        public void UpdateAppointment(Classes.Model.Appointment appointment)
        {
            ReadJson();
            int index = appointments.FindIndex(obj => obj.id == appointment.id);
            appointments[index] = appointment;
            writeInJson();
        }
        

        public void DeleteAppointment(int appointmentId)
        {
            int index = appointments.FindIndex(obj => obj.id == appointmentId);
            appointments.RemoveAt(index);
            writeInJson();
        }
      
      public List<Appointment> readAllAppointments()
      {
            ReadJson();
            return appointments;
      }
      
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> ReadDoctorAppointments(string doctorJmbg)
      {
            ReadJson();
            return appointments.FindAll(appointment => appointment.doctorJmbg == doctorJmbg);

      }

      public List<Appointment> ReadPatientAppointments(string patientJmbg)
      {
            ReadJson();
            return appointments.FindAll(appointment => appointment.patientJmbg == patientJmbg);
      }

      


        public string path;
   
   }
}