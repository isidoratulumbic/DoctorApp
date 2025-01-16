using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Repository;

namespace Classes.Service
{
    
    public class MedicineService
    {
        MedicineRepository medicineRepository = new MedicineRepository();
        public int CreateMedicine(Medicine medicine)
        {
            int ind;
            int retVal;
            if (isDeclinedMedicineExist())
            {
                retVal = 2;
            }
            else
            {
                ind = medicineRepository.GenerateId();
                medicine.id = ind;
                retVal = medicineRepository.CreateMedicine(medicine);
            }
            return retVal;
        }
      
      public Medicine ReadMedicine(int medicineId)
      {
         return medicineRepository.ReadMedicine(medicineId);
      }
      
      public void UpdateMedicine(Medicine medicine)
      {
         medicineRepository.UpdateMedicine(medicine);
      }
      public void AcceptMedicine(Medicine medicine)
      {
          medicineRepository.AcceptMedicine(medicine);
      }
      public void DeclineMedicine(int medicineId, string reason)
      {
          medicineRepository.DeclineMedicine(medicineId, reason);
      }

        public int DeleteMedicine(int medicineId)
      {
            int retVal;
            if (isDeclinedMedicineExist())
            {
                retVal = 2;
            }
            else
                retVal = medicineRepository.DeleteMedicine(medicineId);
            return retVal;
      }
      
      public List<Medicine> ReadAllMedicines()
      {
         return medicineRepository.ReadAllMedicines();
      }
        public bool isDeclinedMedicineExist()
        {
            bool declinedExist = false;
            List<Medicine> medicines = medicineRepository.ReadAllMedicines();
            foreach (var medic in medicines)
            {
                if (medic.status == "DECLINED")
                {
                    declinedExist = true;
                    break;
                }
            }
            return declinedExist;
        }
        public void VerificateMedicine(int medicineId)
      {
         throw new NotImplementedException();
      }
      
        
   }
}