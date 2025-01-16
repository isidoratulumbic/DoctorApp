using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Classes.Model;
using Newtonsoft.Json;

namespace Classes.Service
{
   public class HospitalTreatmentService
   {
        public List<HospitalTreatment> hospitalTreatments = JsonConvert.DeserializeObject<List<Classes.Model.HospitalTreatment>>(File.ReadAllText("hospitalTreatments.json"));
        Classes.Repository.HospitalTreatmentRepository hospitalTreatmentRepository = new Classes.Repository.HospitalTreatmentRepository();
        List<Classes.Model.Room> rooms = JsonConvert.DeserializeObject<List<Classes.Model.Room>>(File.ReadAllText("rooms.json"));

        public void CreateHospitalTreatment(HospitalTreatment hospitalTreatment)
        {
            //CheckUniqueDate(hospitalTreatment);
            hospitalTreatmentRepository.CreateHospitalTreatment(hospitalTreatment);
        }

        public HospitalTreatment ReadHospitalTreatmentById(int hospitalTreatmentId)
      {
         throw new NotImplementedException();
      }

        public List<HospitalTreatment> GetHospitalTreatmentsByPatientJmbg(string patientJmbg)
        {
            return hospitalTreatmentRepository.GetHospitalTreatmentsByPatientJmbg(patientJmbg);
        }

        public void ExtendHospitalTreatment(int hospitalTreatmentId, int numberOfDays)
      {
         throw new NotImplementedException();
      }


        public List<HospitalTreatment> readAll()
        {
            return hospitalTreatmentRepository.readAll();
        }

        public bool CheckUniqueDate(HospitalTreatment hospitalTreatment)
        {
            foreach (var ht in hospitalTreatments)
            {
                if (ht.room.Equals(hospitalTreatment.room) && hospitalTreatment.startDate == ht.startDate && hospitalTreatment.endDate == ht.endDate && hospitalTreatment.bed == ht.bed ||
                    ht.room.Equals(hospitalTreatment.room) && hospitalTreatment.startDate == ht.startDate && hospitalTreatment.bed == ht.bed ||
                    ht.room.Equals(hospitalTreatment.room) && hospitalTreatment.endDate == ht.endDate && hospitalTreatment.bed == ht.bed)
                {
                    //The treatment is busy! Change time!
                    return true;
                }
            }
            return false;
        }

        public void Extend(HospitalTreatment hospitalTreatment)
        {           
            //CheckUniqueDate(hospitalTreatment);
            foreach (var ht in hospitalTreatments)
            {
                if (ht.id == hospitalTreatment.id)
                {
                    ht.startDate = hospitalTreatment.startDate;
                    ht.endDate = hospitalTreatment.endDate;
                    ht.room = hospitalTreatment.room;                                        
                }
            }
            hospitalTreatmentRepository.Extend(hospitalTreatment);
        }

        
        public bool CheckValidDate(Classes.Model.HospitalTreatment hospitalTreatment)
        {
            if (Convert.ToDateTime(hospitalTreatment.startDate) < Convert.ToDateTime(hospitalTreatment.endDate))
            {                
                return true;
            }
            return false;
        }
        public bool CheckForBed(Classes.Model.HospitalTreatment hospitalTreatment)
        {
            foreach (var r in rooms)
            {
                if (hospitalTreatment.room.Equals(r.name))
                {
                    string[] krev = r.beds.Split(',');

                    List<string> kreveti = krev.ToList();


                    foreach (var kr in kreveti)
                    {
                        if (hospitalTreatment.bed.Equals(kr.ToString()))
                        {
                            return false;
                        }                       
                    }
                }
            }
            return true;
        }
    }
}