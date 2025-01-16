using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using SIMSKT3;


//namespace SIMSKT3.Service
namespace Classes.Service
{
    public class DoctorService
    {
        //DoctorRepository doctorRepository = new DoctorRepository();


        public void GetAll()
        {
             employeeRepository.getAll();
        }



        public Classes.Repository.DoctorRepository employeeRepository = new DoctorRepository();

        public List<Doctor> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }



        public Classes.Model.Doctor GetOneEmployee(int id)
        {
            return employeeRepository.GetOneEmployee(id);
        }




        public void SaveEmployee(Classes.Model.Doctor newEmployee)
        {
            employeeRepository.SaveNewEmployee(newEmployee);
        }
       
        public void UpdateEmployee(Classes.Model.Doctor updateEmployee)
        {
            employeeRepository.SaveUpdateEmployee(updateEmployee);
        }

       
        public void DeleteEmployee(Classes.Model.Doctor employee)
        {
            employeeRepository.DeleteEmployee(employee);
        }
    }
}
