// File:    SurveyController.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 6:54:51 PM
// Purpose: Definition of Class SurveyController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class SurveyController
   {
      public void CreateSurvey(Survey survey)
      {
            surveyService.CreateSurvey(survey);
        }
      
      public List<Survey> ReadAllSurvey()
      {
            return surveyService.ReadAllSurvey();
        }
      
      public Classes.Service.SurveyService surveyService;
   
   }
}