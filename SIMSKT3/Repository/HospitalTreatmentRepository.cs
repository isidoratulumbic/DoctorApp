
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
   public class HospitalTreatmentRepository
   {
        public List<HospitalTreatment> hospitalTreatments = new List<HospitalTreatment>();

        public void ReadJson()
        {
            if (!File.Exists("hospitalTreatments.json"))
            {
                File.Create("hospitalTreatments.json").Close();
            }

            using (StreamReader r = new StreamReader("hospitalTreatments.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    hospitalTreatments = JsonConvert.DeserializeObject<List<Classes.Model.HospitalTreatment>>(json);
                }
            }
        }

        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(hospitalTreatments, Formatting.Indented);
            File.WriteAllText("hospitalTreatments.json", json);
        }

        public HospitalTreatmentRepository()
        {
            ReadJson();
        }
        public int GenerateId()
        {
            try
            {
                int maxId = hospitalTreatments.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void CreateHospitalTreatment(HospitalTreatment hospitalTreatment)
        {
            ReadJson();
            int Id = GenerateId();
            hospitalTreatment.id = Id;
            hospitalTreatments.Add(hospitalTreatment);
            writeInJson();
        }

        public HospitalTreatment ReadHospitalTreatmentById(int hospitalTreatmentId)
      {
         throw new NotImplementedException();
      }

        public List<HospitalTreatment> GetHospitalTreatmentsByPatientJmbg(string patientJmbg)
        {
            ReadJson();
            return hospitalTreatments.FindAll(hospitalTreatments => hospitalTreatments.patientJmbg == patientJmbg);
        }

        public void ExtendHospitalTreatment(int hospitalTreatmentId, int numberOfDays)
      {
         throw new NotImplementedException();
      }

        public List<HospitalTreatment> readAll()
        {
            return hospitalTreatments;
        }

        public void Extend(HospitalTreatment hospitalTreatment)
        {
            ReadJson();
            int index = hospitalTreatments.FindIndex(obj => obj.id == hospitalTreatment.id);
            hospitalTreatments[index] = hospitalTreatment;
            writeInJson();
        }
    }
}