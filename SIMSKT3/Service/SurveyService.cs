// File:    SurveyService.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 10:24:53 AM
// Purpose: Definition of Class SurveyService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class SurveyService
   {
      public void CreateSurvey(Survey survey)
      {
            surveyRepository.CreateSurvey(survey);
        }
      
      public List<Survey> ReadAllSurvey()
      {
            return surveyRepository.ReadAllSurvey();
        }
      
      public Classes.Repository.SurveyRepository surveyRepository;
   
   }
}