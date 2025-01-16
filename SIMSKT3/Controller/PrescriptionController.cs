// File:    PrescriptionController.cs
// Author:  LENOVO
// Created: Wednesday, May 19, 2021 09:56:47
// Purpose: Definition of Class PrescriptionController

using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class PrescriptionController
   {
        Classes.Service.PrescriptionService prescriptionService = new Classes.Service.PrescriptionService();
        public void AddPrescription(Prescription prescription)
      {
            prescriptionService.AddPrescription(prescription);
      }
      public void UpdatePrescription(Classes.Model.Prescription prescription)
      {
            prescriptionService.UpdatePrescription(prescription);
      }

        public Classes.Model.Prescription GetPrescriptionById(int prescriptionId)
      {
         throw new NotImplementedException();
      }

        public List<Prescription> GetPrescriptionsByPatientJmbg(String patientJmbg)
        {
            return prescriptionService.GetPrescriptionsByPatientJmbg(patientJmbg);
        }

        public bool CheckUniqueId(Classes.Model.Prescription prescription)
        {
            return prescriptionService.CheckUniqueId(prescription);
        }

        public bool CheckForAllergens(Classes.Model.Prescription prescription)
        {
            return prescriptionService.CheckForAllergens(prescription);
        }

        public List<Prescription> readAll()
        {
            return prescriptionService.readAll();
        }
    }
}