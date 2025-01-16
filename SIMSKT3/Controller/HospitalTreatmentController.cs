using System;
using System.Collections.Generic;
using Classes.Model;

namespace Classes.Controller
{
   public class HospitalTreatmentController
   {
        Classes.Service.HospitalTreatmentService hospitalTreatmentService = new Classes.Service.HospitalTreatmentService();
        public void CreateHospitalTreatment(HospitalTreatment hospitalTreatment)
        {
            hospitalTreatmentService.CreateHospitalTreatment(hospitalTreatment);
        }

        public HospitalTreatment ReadHospitalTreatmentById(int hospitalTreatmentId)
      {
         throw new NotImplementedException();
      }
      
      public void ExtendHospitalTreatment(int hospitalTreatmentId, int numberOfDays)
      {
         throw new NotImplementedException();
      }

        public List<HospitalTreatment> GetHospitalTreatmentsByPatientJmbg(String patientJmbg)
        {
            return hospitalTreatmentService.GetHospitalTreatmentsByPatientJmbg(patientJmbg);
        }
        //public Classes.Service.HospitalTreatmentService hospitalTreatmentService;
        public List<HospitalTreatment> readAll()
        {
            return hospitalTreatmentService.readAll();
        }

        public void Extend(HospitalTreatment hospitalTreatment)
        {
            hospitalTreatmentService.Extend(hospitalTreatment);
        }

        public bool CheckValidDate(Classes.Model.HospitalTreatment hospitalTreatment)
        {
            return hospitalTreatmentService.CheckValidDate(hospitalTreatment);
        }
        public bool CheckForBed(Classes.Model.HospitalTreatment hospitalTreatment)
        {
            return hospitalTreatmentService.CheckForBed(hospitalTreatment);
        }
        public bool CheckUniqueDate(Classes.Model.HospitalTreatment hospitalTreatment)
        {
            return hospitalTreatmentService.CheckUniqueDate(hospitalTreatment);
        }

    }
}