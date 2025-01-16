using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Repository;
using Classes.Controller;
using Classes.Repository;

namespace Classes.Service
{
   public class EmployeeService
   {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        public Doctor GetDoctorBySpecialization(string specialization)
        {
            return employeeRepository.GetDoctorBySpecialization(specialization);
        }

      public void CreateEmployee(Classes.Model.Doctor doctor)
      {
            employeeRepository.CreateEmployee(doctor);
      }
      
      public Classes.Model.Doctor ReadEmployee(int id)
      {
         return employeeRepository.ReadEmployee(id);
      }
      
      public void UpdateEmployee(Classes.Model.Doctor doctor)
      {
            employeeRepository.UpdateEmployee(doctor);
      }
      
      public void DeleteEmployeeById(int id)
      {
            employeeRepository.DeleteEmployeeById(id);
      }
      
      public List<Doctor> ReadAllEmployees()
      {
            return employeeRepository.ReadAllEmployees();
      }
      
      public bool MarkOffDaysForDoctor(System.TimeSpan parameter1, string explanation, bool onOffDays)
      {
         throw new NotImplementedException();
      }
      
   
   }
}