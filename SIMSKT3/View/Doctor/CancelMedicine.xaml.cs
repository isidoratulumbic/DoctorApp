using Classes.Controller;
using System;
using System.Collections.Generic;
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
    public partial class CancelMedicine : Window
    {
        string b;
        MedicineController medicineController = new MedicineController();
        public CancelMedicine()
        {
            InitializeComponent();
        }

        public void prebaci(string a)
        {
            //b = a.ToString();
            Textbox11.Text = a.ToString();
        }

        private void Button_ClickConfirm(object sender, RoutedEventArgs e)
        {
            medicineController.DeclineMedicine(Convert.ToInt32(Textbox11.Text), Textbox22.Text);
            Medicals med = new Medicals();
           // med.Show();
            this.Close();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Medicals med = new Medicals();
            //med.Show();
            this.Close();
        }

        private void Confirm_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Confirm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            medicineController.DeclineMedicine(Convert.ToInt32(Textbox11.Text), Textbox22.Text);
            Medicals med = new Medicals();
            // med.Show();
            this.Close();
        }
    }
}
