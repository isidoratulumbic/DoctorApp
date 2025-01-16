using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Service;
using Classes.Repository;


namespace Classes.Controller
{
   public class EmployeeController
   {
        EmployeeService employeeService = new EmployeeService();

        public Doctor GetDoctorBySpecialization(string specialization)
        {
            return employeeService.GetDoctorBySpecialization(specialization);
        }

        public void CreateEmployee(Classes.Model.Doctor doctor)
      {
            employeeService.CreateEmployee(doctor);
      }
      
      public Classes.Model.Doctor ReadEmployee(int id)
      {
            return employeeService.ReadEmployee(id);
        }

        public void UpdateEmployee(Classes.Model.Doctor doctor)
      {
            employeeService.UpdateEmployee(doctor);
      }
      
      public void DeleteEmployeeById(int id)
      {
            employeeService.DeleteEmployeeById(id);
      }
      
      public List<Doctor> ReadAllEmployees()
      {
            return employeeService.ReadAllEmployees();
      }

        


      public bool MarkOffDaysForDoctor(System.TimeSpan parameter1, string explanation, bool onOffDays)
      {
         throw new NotImplementedException();
      }
      
   
   }
}