using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SIMSKT3;

namespace Classes.Repository
{
    public class DoctorRepository
    {



        private String fileLocation = "doctors.txt";




        public List<Doctor> GetAllEmployees()
        {
            List<Doctor> lstEmployees = new List<Doctor>();

            string[] lines = File.ReadAllLines(fileLocation);
            foreach (string line in lines)
            {
                if (line != "")
                {

                    string[] elementi = line.Split(',');
                    Doctor e = new Doctor();


                    e.Id = Convert.ToInt32(elementi[0]);
                    e.FirstName = elementi[1];
                    e.LastName = elementi[2];
                    e.JMBG = elementi[3];
                    e.Specialization = elementi[4];
                    e.OnffDays = elementi[5];
                    e.StartOffDays = elementi[6];
                    e.EndOffDays = elementi[7];
                    e.Explenation = elementi[8];
                    //e.employeeRole = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), elementi[6]);

                    lstEmployees.Add(e);
                }
            }
            return lstEmployees;
        }



        public Classes.Model.Doctor GetOneEmployee(int id)
        {
            Doctor e = new Doctor();
            string[] lines = File.ReadAllLines(fileLocation);
            bool postoji = false;
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] elementi = line.Split(',');
                    if (Convert.ToInt32(elementi[0]) == id)
                    {
                        postoji = true;
                        e.Id = Convert.ToInt32(elementi[0]);
                        e.FirstName = elementi[1];
                        e.LastName = elementi[2];
                        e.JMBG = elementi[3];
                        e.Specialization = elementi[4];
                        e.OnffDays = elementi[5];
                        e.StartOffDays = elementi[6];
                        e.EndOffDays = elementi[7];
                        e.Explenation = elementi[8];
                        //e.employeeRole = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), elementi[6]);
                    }
                }

            }
            if (postoji)
                return e;
            else
                return null;
        }


        public void SaveNewEmployee(Doctor newEmployee)
        {
            string tekstAppend = "\n" + newEmployee.Id + "," + newEmployee.FirstName + "," + newEmployee.LastName + newEmployee.JMBG + "," + newEmployee.Specialization + "," + newEmployee.OnffDays + "," + newEmployee.StartOffDays + "," + newEmployee.EndOffDays + "," + newEmployee.Explenation;
            File.AppendAllText(fileLocation, tekstAppend);
        }


        public void SaveUpdateEmployee(Doctor updateEmployee)
        {
            string[] lines = File.ReadAllLines(fileLocation);
            bool postoji = false;
            List<string> modifikovanaLista = new List<string>();                    //u ovu listu se dodaju svi redovi, s modifikovanim redom
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] elementi = line.Split(',');                            //podeli liniju po delimiteru
                    if (Convert.ToInt32(elementi[0]) == updateEmployee.Id)          //ako pronadje po id modifikovati liniju podacima prosledjenog objekta
                    {
                        postoji = true;
                        modifikovanaLista.Add(updateEmployee.Id + "," + updateEmployee.FirstName + "," + updateEmployee.LastName + "," + updateEmployee.FirstName + "," + updateEmployee.LastName + "," + updateEmployee.JMBG + "," + updateEmployee.Specialization + "," + updateEmployee.OnffDays + "," + updateEmployee.StartOffDays + "," + updateEmployee.EndOffDays + "," + updateEmployee.Explenation);
                    }
                    else
                        modifikovanaLista.Add(line);

                }

            }
            if (postoji)//prebrisati podatke ako je ucinjena modifikacija
                File.WriteAllLines(fileLocation, modifikovanaLista);

        }


        public void DeleteEmployee(Classes.Model.Doctor employee)
        {
            string[] lines = File.ReadAllLines(fileLocation);
            bool postoji = false;
            List<string> linijeBezBrisanja = new List<string>();                               //u ovu listu se dodaju redovi koji ne sadrze medicine koji ima id za brisanje
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] elementi = line.Split(',');
                    if (Convert.ToInt32(elementi[0]) != employee.Id)
                    {
                        linijeBezBrisanja.Add(line);
                    }
                    else
                        postoji = true;
                }

            }
            if (postoji)
                File.WriteAllLines(fileLocation, linijeBezBrisanja);
        }






























        //    public List<Patient> doctors = new List<Patient>();

        //    public DoctorRepository()
        //    {
        //        if (!File.Exists("doctors.json"))
        //        {
        //            File.Create("doctors.json").Close();
        //        }

        //        using (StreamReader r = new StreamReader("doctors.json"))
        //        {
        //            string json = r.ReadToEnd();
        //            if (json != "")
        //            {
        //                doctors = JsonConvert.DeserializeObject<List<Patient>>(json);
        //            }
        //        }
        //    }
        //    public void writeInJson()
        //    {
        //        string json = JsonConvert.SerializeObject(doctors, Formatting.Indented);
        //        File.WriteAllText("doctors.json", json);
        //    }
            public void getAll()
            {
                //return doctors;
            }

        //    public void save(Classes.Model.Patient doctor)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void delete(int id)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public Classes.Model.Patient getById(int id)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public Classes.Model.Patient update(Classes.Model.Patient doctor)
        //    {
        //        throw new NotImplementedException();
        //    }

            public string path;

        //}
    }
}