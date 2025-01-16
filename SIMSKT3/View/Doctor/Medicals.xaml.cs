using Classes.Controller;
using Classes.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SIMSKT3.View.Doctor
{
    public partial class Medicals : Page
    {
        
        string prebaci;
        public List<Medicine> medicines = new List<Medicine>();
        MedicineController medicineController = new MedicineController();


        public Medicals()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            
        }

        private void Button_ClickMedicines(object sender, RoutedEventArgs e)
        {
            lv_medicines.Items.Clear();
            List<Classes.Model.Medicine> medicines = JsonConvert.DeserializeObject<List<Classes.Model.Medicine>>(File.ReadAllText("medicine.json"));
            foreach (var medic in medicines)
            {
                lv_medicines.Items.Add(medic);
            }
        }

        private void Button_ClickCancelMedicine(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text.Equals("")) { MessageBox.Show("Select medicine!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
            prebaci = Textbox1.Text;
            CancelMedicine cm = new CancelMedicine();
            cm.prebaci(prebaci.ToString());
            cm.Show();
            
        }

        private void Button_ClickUpdateMedicine(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.Medicine med = new Classes.Model.Medicine(Convert.ToInt32(Textbox1.Text), Textbox2.Text, status.Text, Textbox3.Text, null, null, null);
                medicineController.UpdateMedicine(med);
                MessageBox.Show("Medication is successfully updated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Select medicine!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void Button_Click_Accept(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text.Equals("")) { MessageBox.Show("Select medicine!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
            Classes.Model.Medicine medi = new Classes.Model.Medicine(Convert.ToInt32(Textbox1.Text), Textbox2.Text, status.Text, Textbox3.Text, null, null, null);            
            medicineController.AcceptMedicine(medi);
            MessageBox.Show("Medicine is validated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Textbox2_Error(object sender, ValidationErrorEventArgs e)
        {

        }

        private void SeeAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SeeAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            lv_medicines.Items.Clear();
            List<Classes.Model.Medicine> medicines = JsonConvert.DeserializeObject<List<Classes.Model.Medicine>>(File.ReadAllText("medicine.json"));
            foreach (var medic in medicines)
            {
                lv_medicines.Items.Add(medic);
            }
        }

        private void UpdateMedication_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void UpdateMedication_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                Classes.Model.Medicine med = new Classes.Model.Medicine(Convert.ToInt32(Textbox1.Text), Textbox2.Text, status.Text, Textbox3.Text, null, null, null);
                medicineController.UpdateMedicine(med);
                MessageBox.Show("Medication is successfully updated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Select medicine!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void Accept_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Accept_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Textbox1.Text.Equals("")) { MessageBox.Show("Select medicine!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
            Classes.Model.Medicine medi = new Classes.Model.Medicine(Convert.ToInt32(Textbox1.Text), Textbox2.Text, status.Text, Textbox3.Text, null, null, null);
            medicineController.AcceptMedicine(medi);
            MessageBox.Show("Medicine is validated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Decline_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Decline_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Textbox1.Text.Equals("")) { MessageBox.Show("Select medicine!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); return; }
            prebaci = Textbox1.Text;
            CancelMedicine cm = new CancelMedicine();
            cm.prebaci(prebaci.ToString());
            cm.Show();

        }

       
    }
}
