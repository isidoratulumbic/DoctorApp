// File:    ReferralLetterForSpecialistRepository.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 10:30:19 AM
// Purpose: Definition of Class ReferralLetterForSpecialistRepository

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
    public class ReferralLetterForSpecialistRepository
    {
        public List<ReferralLetterForSpecialist> referralLetterForSpecialist = JsonConvert.DeserializeObject<List<Classes.Model.ReferralLetterForSpecialist>>(File.ReadAllText("referralLetters.json"));
        public void ReadJson()
        {
            if (!File.Exists("referralLetters.json"))
            {
                File.Create("referralLetters.json").Close();
            }

            using (StreamReader r = new StreamReader("referralLetters.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    referralLetterForSpecialist = JsonConvert.DeserializeObject<List<Classes.Model.ReferralLetterForSpecialist>>(json);
                }
            }
        }

        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(referralLetterForSpecialist, Formatting.Indented);
            File.WriteAllText("referralLetters.json", json);
        }

        public ReferralLetterForSpecialistRepository()
        {
            ReadJson();
        }

        public int GenerateId()
        {
            try
            {
                int maxId = referralLetterForSpecialist.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void CreateReferralLetter(ReferralLetterForSpecialist letter)
        {
            ReadJson();
            int Id = GenerateId();
            letter.id = Id;
            referralLetterForSpecialist.Add(letter);
            writeInJson();
        }

        public ReferralLetterForSpecialist ReadReferralLetter(int referralLetterId)
        {
            throw new NotImplementedException();
        }

        public List<ReferralLetterForSpecialist> GetReferralLettersByPatientJmbg(string patientJmbg)
        {
            ReadJson();
            return referralLetterForSpecialist.FindAll(referralLetterForSpecialist => referralLetterForSpecialist.patientJmbg == patientJmbg);
            
        }

        public List<ReferralLetterForSpecialist> ReadAllReferralLetter()
      {
         throw new NotImplementedException();
      }

        public void DeleteReferralLetter(int referralLetterId)
        {
            ReadJson();

            foreach (var ap in referralLetterForSpecialist.ToArray())
            {
                if (ap.id == referralLetterId)
                {
                    referralLetterForSpecialist.Remove(ap);
                    writeInJson();
                }
            }
        }

    }
}