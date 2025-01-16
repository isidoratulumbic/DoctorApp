// File:    ReferralLetterForSpecialistService.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 10:29:11 AM
// Purpose: Definition of Class ReferralLetterForSpecialistService

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Service
{
   public class ReferralLetterForSpecialistService
   {
        Classes.Repository.ReferralLetterForSpecialistRepository referralLetterForSpecialistRepository = new Classes.Repository.ReferralLetterForSpecialistRepository();
        
        public void CreateReferralOperation(ReferralLetterForSpecialist letter)
        {
            letter.type = "Operation";
            referralLetterForSpecialistRepository.CreateReferralLetter(letter);
        }
        public void CreateReferralExamination(ReferralLetterForSpecialist letter)
        {
            letter.type = "Examination";
            referralLetterForSpecialistRepository.CreateReferralLetter(letter);
        }
        public void CreateReferralAdmition(ReferralLetterForSpecialist letter)
        {
            letter.type = "Admition";
            referralLetterForSpecialistRepository.CreateReferralLetter(letter);
        }


        public Classes.Controller.ReferralLetterForSpecialistController ReadReferralLetter(int referralLetterId)
      {
         throw new NotImplementedException();
      }
      
      public List<ReferralLetterForSpecialist> ReadAllReferralLetter()
      {
         throw new NotImplementedException();
      }

        public List<ReferralLetterForSpecialist> GetReferralLettersByPatientJmbg(string patientJmbg)
        {
            return referralLetterForSpecialistRepository.GetReferralLettersByPatientJmbg(patientJmbg);
        }

        public void DeleteReferralLetter(int referralLetterId)
        {
            referralLetterForSpecialistRepository.DeleteReferralLetter(referralLetterId);
        }

    }
}