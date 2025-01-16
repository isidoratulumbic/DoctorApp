// File:    ReferralLetterForSpecialistController.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 6:58:47 PM
// Purpose: Definition of Class ReferralLetterForSpecialistController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class ReferralLetterForSpecialistController
   {
        Classes.Service.ReferralLetterForSpecialistService referralLetterForSpecialistService = new Classes.Service.ReferralLetterForSpecialistService();
        
        public void CreateReferralOperation(ReferralLetterForSpecialist referralLetter)
        {
            referralLetterForSpecialistService.CreateReferralOperation(referralLetter);
        }
        public void CreateReferralExamination(ReferralLetterForSpecialist referralLetter)
        {
            referralLetterForSpecialistService.CreateReferralExamination(referralLetter);
        }
        public void CreateReferralAdmition(ReferralLetterForSpecialist referralLetter)
        {
            referralLetterForSpecialistService.CreateReferralAdmition(referralLetter);
        }

        public ReferralLetterForSpecialistController ReadReferralLetter(int referralLetterId)
      {
         throw new NotImplementedException();
      }
      
      public List<ReferralLetterForSpecialist> ReadAllReferralLetter()
      {
         throw new NotImplementedException();
      }

        public List<ReferralLetterForSpecialist> GetReferralLettersByPatientJmbg(String patientJmbg)
        {
            return referralLetterForSpecialistService.GetReferralLettersByPatientJmbg(patientJmbg);
        }

        public void DeleteReferralLetter(int referralLetterId)
        {
            referralLetterForSpecialistService.DeleteReferralLetter(referralLetterId);
        }

    }
}