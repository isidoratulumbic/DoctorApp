// File:    PrescriptionService.cs
// Author:  LENOVO
// Created: Wednesday, May 19, 2021 10:00:54
// Purpose: Definition of Class PrescriptionService

using System;
using System.Collections.Generic;
using System.IO;
using Classes.Model;
using Newtonsoft.Json;

namespace Classes.Service
{
   public class PrescriptionService
   {
        Classes.Repository.PrescriptionRepository prescriptionRepository = new Classes.Repository.PrescriptionRepository();
        public void AddPrescription(Prescription prescription)
      {
            prescriptionRepository.AddPrescription(prescription);
      }

        public void UpdatePrescription(Classes.Model.Prescription prescription)
        {
            prescriptionRepository.UpdatePrescription(prescription);
        }

        public Classes.Model.Prescription GetPrescriptionById(int prescriptionId)
      {
         throw new NotImplementedException();
      }

        public List<Prescription> GetPrescriptionsByPatientJmbg(string patientJmbg)
        {
            return prescriptionRepository.GetPrescriptionsByPatientJmbg(patientJmbg);
        }
        public List<Prescription> readAll()
        {
            return prescriptionRepository.readAll();
        }

        public bool CheckForAllergens(Classes.Model.Prescription prescription)
        {
            List<Classes.Model.Medicine> medicines = JsonConvert.DeserializeObject<List<Classes.Model.Medicine>>(File.ReadAllText("medicine.json"));
            List<Classes.Model.Patient> patients = JsonConvert.DeserializeObject<List<Classes.Model.Patient>>(File.ReadAllText("patients2.json"));
            foreach (var m in medicines)
            {
                if (prescription.medicinee.Equals(m.name))
                {
                    foreach (var p in patients)
                    {
                        if (prescription.patientJmbg.Equals(p.jmbg))
                        {
                            if (m.ingredients.Contains(p.allergen))
                            {
                                //The patient is allergic to this medicine, choose another!
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        
        public bool CheckUniqueId(Classes.Model.Prescription prescription)
        {
            List<Appointment> prescriptions = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("prescriptions.json"));
            foreach (var pres in prescriptions)
            {
                if (pres.id == Convert.ToInt32(prescription.id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}