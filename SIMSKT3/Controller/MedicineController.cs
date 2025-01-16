
using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Service;

namespace Classes.Controller
{
    
    public class MedicineController
    {
      MedicineService medicineService = new MedicineService();
      public int CreateMedicine(Medicine medicine)
      {
         return medicineService.CreateMedicine(medicine);
      }
      
      public Medicine ReadMedicine(int medicineId)
      {
         return medicineService.ReadMedicine(medicineId);
      }
      
      public void UpdateMedicine(Medicine medicine)
      {
          medicineService.UpdateMedicine(medicine);
      }
      public void AcceptMedicine(Medicine medicine)
      {
          medicineService.AcceptMedicine(medicine);
      }

        public int DeleteMedicine(int medicineId)
      {
         return medicineService.DeleteMedicine(medicineId);
      }
      
      public List<Medicine> ReadAllMedicines()
      {
         return medicineService.ReadAllMedicines();
      }
      
      public void VerificateMedicine(int medicineId)
      {
         throw new NotImplementedException();
      }
      
      public void DeclineMedicine(int medicineId, string reason)
      {
         medicineService.DeclineMedicine(medicineId, reason);
      }
   }
}