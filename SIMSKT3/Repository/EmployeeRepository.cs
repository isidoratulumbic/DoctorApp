using System;
using System.Collections.Generic;
using System.IO;
using Classes.Model;
using Newtonsoft.Json;
using Classes.Service;
using Classes.Controller;
using Classes.Service;

namespace Classes.Repository
{
   public class EmployeeRepository
   {
        public List<Doctor> doctors = new List<Doctor>();


        public EmployeeRepository()
        {
            if (!File.Exists("doctors.json"))
            {
                File.Create("doctors.json").Close();
            }

            using (StreamReader r = new StreamReader("doctors.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    doctors = JsonConvert.DeserializeObject<List<Doctor>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(doctors, Formatting.Indented);
            File.WriteAllText("doctors.json", json);
        }
        public Doctor GetDoctorBySpecialization(string specialization)
        {
            return doctors.Find(obj => obj.specialization == specialization);
        }

        public void CreateEmployee(Classes.Model.Doctor doctor)
        {
            doctors.Add(doctor);
            writeInJson();
        }
      
      public Classes.Model.Doctor ReadEmployee(int id)
      {
            return doctors.Find(obj => obj.id == id);
      }

        public void UpdateEmployee(Classes.Model.Doctor doctor)
      {
            int index = doctors.FindIndex(obj => obj.id == doctor.id);
            doctors[index] = doctor;
            writeInJson();
        }
      
      public void DeleteEmployeeById(int id)
      {
            foreach (var doc in doctors.ToArray())
            {
                if (doc.id == id)
                {
                    doctors.Remove(doc);
                    writeInJson();
                }
            }
        }
      
      public List<Doctor> ReadAllEmployees()
      {
            return doctors;
      }
      
      public bool MarkOffDaysForDoctor(System.TimeSpan parameter1, string explanation, bool onOffDays)
      {
         throw new NotImplementedException();
      }
   
   }
}