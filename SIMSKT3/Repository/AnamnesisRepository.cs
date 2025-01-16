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
   public class AnamnesisRepository
   {

        public List<Anamnesis> anamnesiss = new List<Anamnesis>();
        public void ReadJson()
        {
            if (!File.Exists("anamnesis.json"))
            {
                File.Create("anamnesis.json").Close();
            }

            using (StreamReader r = new StreamReader("anamnesis.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    anamnesiss = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(json);
                }
            }
        }

        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(anamnesiss, Formatting.Indented);
            File.WriteAllText("anamnesis.json", json);
        }

        public AnamnesisRepository()
        {
            ReadJson();
        }
        public int GenerateId()
        {
            try
            {
                int maxId = anamnesiss.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void CreateAnamnesis(Classes.Model.Anamnesis anamnesis)
        {
            ReadJson();
            int Id = GenerateId();
            anamnesis.id = Id;
            anamnesiss.Add(anamnesis);
            writeInJson();
        }
      
        public void UpdateAnamnesis(Classes.Model.Anamnesis anamnesis)
        {
            ReadJson();
            int index = anamnesiss.FindIndex(obj => obj.id == anamnesis.id);
            anamnesiss[index] = anamnesis;
            writeInJson();
        }

        public List<Classes.Model.Anamnesis> GetAnamnesisByPatientJmbg(string patientJmbg)
        {
            ReadJson();
            return anamnesiss.FindAll(anamnesis => anamnesis.patientJmbg == patientJmbg);
        }

        public List<Anamnesis> readAllAnamnesis()
        {
            ReadJson();
            return anamnesiss;
        }

    }
}