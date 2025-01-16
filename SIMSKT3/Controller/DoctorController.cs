using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using SIMSKT3.View;

namespace Classes.Controller
{
    public class DoctorController
    {

        public static ObservableCollection<Doctor> lstEmployees;
        public DoctorController()
        {
            lstEmployees = new ObservableCollection<Doctor>(GetAllEmployees());
        }


        public void initializeDgEmployees(DataGrid dgEmployee)
        {
            dgEmployee.ItemsSource = lstEmployees;
        }

        public void initializeDgEmployee_Search(DataGrid dgEmployee, string textSearch)
        {
            if (textSearch.Equals(""))
                initializeDgEmployees(dgEmployee);
            else
            {
                lstEmployees.Clear();
                ObservableCollection<Doctor> lst = new ObservableCollection<Doctor>(GetAllEmployees());
                foreach (Doctor eed in lst)
                    if (eed.FirstName.Contains(textSearch) || eed.LastName.Contains(textSearch) || eed.JMBG.Contains(textSearch) || eed.JMBG.Contains(textSearch) || eed.Specialization.Contains(textSearch) || eed.OnffDays.Contains(textSearch) || eed.StartOffDays.Contains(textSearch) || eed.EndOffDays.Contains(textSearch) || eed.Explenation.Contains(textSearch))
                        lstEmployees.Add(eed);


                dgEmployee.ItemsSource = lstEmployees;

            }
        }



        public Classes.Service.DoctorService employeeService = new DoctorService();


        public List<Doctor> GetAllEmployees()
        {
            return employeeService.GetAllEmployees();
        }



        public Classes.Model.Employee GetOneEmployee(int id)
        {
            return employeeService.GetOneEmployee(id);
        }



        public void SaveEmployee(Classes.Model.Doctor newEmployee)
        {
            employeeService.SaveEmployee(newEmployee);
        }
        
        public void UpdateEmployee(Classes.Model.Doctor newEmployee)
        {
            employeeService.UpdateEmployee(newEmployee);
        }

        public void DeleteEmployee(Classes.Model.Doctor employee)
        {
            employeeService.DeleteEmployee(employee);
        }



        public void initialize_appearence(Doctor employee, Window w/*, Button btn*/)
        {
            if (employee != null)
            {
                w.Title = "Editing doctor";
                //btn.Content = "Edit";

            }
        }

        public void initialize_Id(Doctor emp, TextBox tb)
        {
            if (emp != null)
                tb.Text = emp.Id.ToString();
            else
            {
                int newId = 0;
                foreach (Doctor m in GetAllEmployees())
                    if (m.Id > newId)
                        newId = m.Id;
                newId++;

                tb.Text = newId.ToString();
            }

            tb.IsEnabled = false;
        }



        public void initialize_Text_Fields(Doctor emp,TextBox tbFirstName, TextBox tbLastName, TextBox tbJMBG, TextBox tbSpecialization, TextBox tbOnOff, TextBox tbStartOff, TextBox tbEndOff, TextBox tbExp)
        {
            if (emp != null)
            {
                tbFirstName.Text = emp.FirstName;
                tbLastName.Text = emp.LastName;
                tbJMBG.Text = emp.JMBG;
                tbSpecialization.Text = emp.Specialization;
                tbEndOff.Text = emp.OnffDays;
                tbStartOff.Text = emp.StartOffDays;
                tbEndOff.Text = emp.EndOffDays;
                tbExp.Text = emp.Explenation;


            }
        }




        /// U formi za Add/EDit medicine objekta kad se klikne na Add/Edit
        public void addEdit_Employee_Confirmation(Doctor emp, Doctor employee_add_edit, DataGrid dgEmployee, Window w) //room objekat null ako se pravi novi objekat, !=null za izmenu..   medicine_add_edit prosledjeni podaci s forme
        {


            if (emp == null)
            {
                SaveEmployee(employee_add_edit);
                lstEmployees = new ObservableCollection<Doctor>(GetAllEmployees());
                dgEmployee.ItemsSource = lstEmployees;
            }
            else
            {
                UpdateEmployee(employee_add_edit);
                lstEmployees = new ObservableCollection<Doctor>(GetAllEmployees());
                dgEmployee.ItemsSource = lstEmployees;

            }
            MessageBox.Show("Created vacation report!");
            w.Close();

        }


      

        public void delete_DeleteButton_Pressed(Doctor emp, DataGrid dgEmployee)
        {

            DeleteConfirmation frm = new DeleteConfirmation();
            frm.ShowDialog();

            if (frm.DialogResult == true)
            {
                DeleteEmployee(emp);
                lstEmployees = new ObservableCollection<Doctor>(GetAllEmployees());
                dgEmployee.ItemsSource = lstEmployees;

            }
        }

    





























DoctorService doctorService = new DoctorService();

        public void readAll()
        {
             doctorService.GetAll();
        }

        public List<Appointment> GetAllAppointments()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedicalRecord(int patientId)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Anamnesis CreateAnamnesis(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Anamnesis UpdateAnamnesis(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Prescription AddPrescription(int id, string medicine, string usage, string quantity)
        {
            throw new NotImplementedException();
        }

        public Classes.Service.AppointmentService appointmentService;
        public Classes.Service.MedicalRecordService medicalRecordService;

    }
}