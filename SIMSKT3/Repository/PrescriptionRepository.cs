using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Classes.Repository
{
   public class PrescriptionRepository
   {

        public List<Prescription> prescriptions = new List<Prescription>();
        public void ReadJson()
        {
            if (!File.Exists("prescriptions.json"))
            {
                File.Create("prescriptions.json").Close();
            }

            using (StreamReader r = new StreamReader("prescriptions.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    prescriptions = JsonConvert.DeserializeObject<List<Classes.Model.Prescription>>(json);
                }
            }
        }

        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(prescriptions, Formatting.Indented);
            File.WriteAllText("prescriptions.json", json);
        }

        public PrescriptionRepository()
        {
            ReadJson();
        }
        public int GenerateId()
        {
            try
            {
                int maxId = prescriptions.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void AddPrescription(Prescription prescription)
        {
            ReadJson();
            int Id = GenerateId();
            prescription.id = Id;
            prescriptions.Add(prescription);
            writeInJson();
        }
        public void UpdatePrescription(Classes.Model.Prescription prescription)
        {
            ReadJson();
            int index = prescriptions.FindIndex(obj => obj.id == prescription.id);
            prescriptions[index] = prescription;
            writeInJson();
        }

        public Classes.Model.Prescription GetPrescriptionById(int prescriptionId)
      {
         throw new NotImplementedException();
      }

        public List<Classes.Model.Prescription> GetPrescriptionsByPatientJmbg(string patientJmbg)
        {
            ReadJson();
            return prescriptions.FindAll(prescriptions => prescriptions.patientJmbg == patientJmbg);
        }

        public List<Prescription> readAll()
        {
            return prescriptions;
        }

    }
}