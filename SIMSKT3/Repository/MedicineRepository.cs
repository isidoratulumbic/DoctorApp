using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Classes.Model;
using Newtonsoft.Json;

namespace Classes.Repository
{
   public class MedicineRepository
   {
      public List<Medicine> medicines = new List<Medicine>();
      public MedicineRepository()
      {
            if (!File.Exists("medicine.json"))
            {
                File.Create("medicine.json").Close();
            }

            using (StreamReader r = new StreamReader("medicine.json"))
            {
              string json = r.ReadToEnd();
              if (json != "")
              {
                  medicines = JsonConvert.DeserializeObject<List<Medicine>>(json);
              }
          }
      }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(medicines, Formatting.Indented);
            File.WriteAllText("medicine.json", json);
        }

        public int CreateMedicine(Medicine medicine)
      {
            int retVal;
            medicines.Add(medicine);
            writeInJson();
            return retVal = 1;
        }
      
      public Medicine ReadMedicine(int medicineId)
      {
         Medicine m=null;
         foreach(var medic in medicines.ToList())
         {
             if (medic.id == medicineId)
             {
                    m = medic;
                    break;
             }
         }
         return m;
      }
      
      public void UpdateMedicine(Medicine medicine)
      {
            int index = medicines.FindIndex(obj => obj.id == medicine.id);
            medicines[index] = medicine;
            writeInJson();
        }
      
      public int DeleteMedicine(int medicineId)
      {
            int retVal;
            int index = medicines.FindIndex(obj => obj.id == medicineId);
            medicines.RemoveAt(index);
            writeInJson();
            return retVal = 1;
        }
      
      public List<Medicine> ReadAllMedicines()
      {
         return medicines;
      }
      
      public void VerificateMedicine(int medicineId)
      {
            try
            {
                //List<Medicine> medi = new Medicine(medicines);
                foreach (var med in medicines)
                {
                    if (med.id == medicineId)
                    {
                        med.status = "VALIDATED";
                        writeInJson();
                        string lines = "Medicine accepted:" + med.name + "\n";
                        File.AppendAllText("statusMedicine.txt", lines);
                        return;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public void AcceptMedicine(Medicine medicine)
        {
            try
            {
                //List<Medicine> medi = new Medicine(medicines);
                foreach (var med in medicines)
                {
                    if (med.id == medicine.id)
                    {
                        med.status = "VALIDATED";
                        writeInJson();
                        string lines = "Medicine accepted:" + med.name + "\n";
                        File.AppendAllText("statusMedicine.txt", lines);
                        return;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public void DeclineMedicine(int medicineId, string reason)
      {
            foreach (var med in medicines.ToArray())
            {
                if (med.id == medicineId)
                {
                    med.status = "DECLINED";
                    med.reason = reason;
                    writeInJson();
                }
            }
        }
        //public void updateMed(Medicine medicine)
        //{
        //    try
        //    {
        //        //List<Medicine> medi = new Medicine(medicines);
        //        foreach (var med in medicines)
        //        {
        //            if (med.id == medicine.id)
        //            {
        //                med.name = medicine.name;
        //                med.description = medicine.description;

        //                writeInJson();

        //                return;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }

        //}
        public int GenerateId()
        {
            try
            {
                int maxId = medicines.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
        public string path;
   }
}