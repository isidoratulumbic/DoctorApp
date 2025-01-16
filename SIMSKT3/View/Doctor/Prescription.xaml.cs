using Classes.Controller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SIMSKT3.View.Doctor
{
    
    public partial class Prescription : Page, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private double _numbers;
        public double Numbers
        {
            get
            {
                return _numbers;
            }
            set
            {
                if (value != _numbers)
                {
                    _numbers = value;
                    OnPropertyChanged("Username");
                }
            }
        }
        private string _letters;
        public string Letters
        {
            get
            {
                return _letters;
            }
            set
            {
                if (value != _letters)
                {
                    _letters = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        PrescriptionController prescriptionController = new PrescriptionController();
        List<Classes.Model.Prescription> prescriptions = JsonConvert.DeserializeObject<List<Classes.Model.Prescription>>(File.ReadAllText("prescriptions.json"));


        public Prescription()
        {
            InitializeComponent();
            this.DataContext = this;

            List<Classes.Model.Patient> patients = JsonConvert.DeserializeObject<List<Classes.Model.Patient>>(File.ReadAllText("patients2.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patients.Items.Add(pat.jmbg);


            }

            List<Classes.Model.Medicine> medicines = JsonConvert.DeserializeObject<List<Classes.Model.Medicine>>(File.ReadAllText("medicine.json"));
            foreach (var med in medicines.ToList())
            {
                cb_medicines.Items.Add(med.name);
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            cb_medicines.Text = " ";
            Textbox3.Text = " ";
            Textbox4.Text = " ";
        }

        public void Button_AddPrescription(object sender, RoutedEventArgs e)
        {
            Classes.Model.Prescription prescription = new Classes.Model.Prescription(cb_patients.Text,
                                                                            Convert.ToDateTime(datePicker.Text),
                                                                            cb_medicines.Text,
                                                                            Convert.ToInt32(Textbox3.Text),
                                                                            Textbox4.Text);
            
            if (prescriptionController.CheckUniqueId(prescription))
            {
                MessageBox.Show("ID already exist!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

           /* if (prescriptionController.CheckForAllergens(prescription))
            {
                MessageBox.Show("The patient is allergic to this medicine, choose another!");
                return;
            }*/

            prescriptionController.AddPrescription(prescription);
            MessageBox.Show("Prescription is successfully added!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Button_UpdatePrescription(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.Prescription prescription = new Classes.Model.Prescription(
                                                                                cb_patients.Text,
                                                                                Convert.ToDateTime(datePicker.Text),
                                                                                cb_medicines.Text,
                                                                                Convert.ToInt32(Textbox3.Text),
                                                                                Textbox4.Text);
                foreach (var a in prescriptions)
                {
                    if (a.quantity == Convert.ToInt32(Textbox3.Text))
                    {
                        a.quantity = prescription.quantity;
                        a.usage = prescription.usage;
                    }
                }
                prescriptionController.UpdatePrescription(prescription);
                MessageBox.Show("Prescription is successfully updated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Select prescription to update!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void cb_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
        private void lv_prescriptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
       /* private void read_AllPrescriptions(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_prescriptions.Items.Clear();
                List<Classes.Model.Prescription> prescription = JsonConvert.DeserializeObject<List<Classes.Model.Prescription>>(File.ReadAllText("prescriptions.json"));
                foreach (var rl in prescription)
                {
                    lv_prescriptions.Items.Add(rl);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any referral letter!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }*/
        private void read_AllPrescriptions(object sender, RoutedEventArgs e)
        {            
            List<Classes.Model.Prescription> prescriptions = prescriptionController.readAll();
            lv_prescriptions.ItemsSource = prescriptions;

        }

        

        private void Button_BackToDr(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            
        }
        

        private void cb_medicines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Create_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Create_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Classes.Model.Prescription prescription = new Classes.Model.Prescription(cb_patients.Text,
                                                                            Convert.ToDateTime(datePicker.Text),
                                                                            cb_medicines.Text,
                                                                            Convert.ToInt32(Textbox3.Text),
                                                                            Textbox4.Text);

            if (prescriptionController.CheckUniqueId(prescription))
            {
                MessageBox.Show("ID already exist!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            /* if (prescriptionController.CheckForAllergens(prescription))
             {
                 MessageBox.Show("The patient is allergic to this medicine, choose another!");
                 return;
             }*/

            prescriptionController.AddPrescription(prescription);
            MessageBox.Show("Prescription is successfully added!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void Update_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Update_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                Classes.Model.Prescription prescription = new Classes.Model.Prescription(
                                                                                cb_patients.Text,
                                                                                Convert.ToDateTime(datePicker.Text),
                                                                                cb_medicines.Text,
                                                                                Convert.ToInt32(Textbox3.Text),
                                                                                Textbox4.Text);
                foreach (var a in prescriptions)
                {
                    if (a.quantity == Convert.ToInt32(Textbox3.Text))
                    {
                        a.quantity = prescription.quantity;
                        a.usage = prescription.usage;
                    }
                }
                prescriptionController.UpdatePrescription(prescription);
                MessageBox.Show("Prescription is successfully updated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Select prescription to update!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void ClearFields_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ClearFields_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            cb_medicines.Text = " ";
            Textbox3.Text = " ";
            Textbox4.Text = " ";
        }


        private void SeeAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SeeAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            List<Classes.Model.Prescription> prescriptions = prescriptionController.readAll();
            lv_prescriptions.ItemsSource = prescriptions;
        }
    }
}

