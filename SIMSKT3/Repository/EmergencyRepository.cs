using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SIMSKT3;


namespace SIMSKT3.Repository
{
    class EmergencyRepository
    {
        public List<Patient> patients = new List<Patient>();

        public EmergencyRepository()
        {
            if (!File.Exists("EmergencyPatients.json"))
            {
                File.Create("EmergencyPatients.json").Close();
            }

            using (StreamReader r = new StreamReader("EmergencyPatients.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    patients = JsonConvert.DeserializeObject<List<Patient>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText("EmergencyPatients.json", json);
        }

        public void deletePatientFromStorage(int id)
        {
            int index = patients.FindIndex(obj => obj.id == id);
            patients.RemoveAt(index);
            writeInJson();
        }

        public Patient readPatient(int id)
        {
            return patients.Find(obj => obj.id == id);
        }

        public List<Patient> getAllPatients()
        {
            return patients;
        }
        public void DeleteAll()
        {
            foreach (var all in patients.ToArray())
            {
                patients.Remove(all);
            }
            writeInJson();
        }

        public void CreatePatients(Patient patient)
        {
            patients.Add(patient);
            writeInJson();
        }

        public void UpdatePatients(Patient patient)
        {
            int index = patients.FindIndex(obj => obj.id == patient.id);
            patients[index] = patient;
            writeInJson();
        }


        public string path;

    }


}



