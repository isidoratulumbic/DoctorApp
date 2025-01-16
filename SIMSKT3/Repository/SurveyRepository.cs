using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Classes.Repository
{
   public class SurveyRepository
   {
        public List<Survey> surveys = new List<Survey>();

        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(surveys, Formatting.Indented);
            File.WriteAllText("survey.json", json);
        }

        public void ReadJson()
        {
            if (!File.Exists("survey.json"))
            {
                File.Create("survey.json").Close();
            }

            using (StreamReader r = new StreamReader("survey.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    surveys = JsonConvert.DeserializeObject<List<Survey>>(json);
                }
            }
        }

        public SurveyRepository()
        {
            ReadJson();
        }
        public void CreateSurvey(Survey survey)
        {
            ReadJson();

            surveys.Add(survey);
            writeInJson();
        }

        public List<Survey> ReadAllSurvey()
        {
            ReadJson();
            return surveys;
        }

    }
}