using Classes.Controller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

    public partial class Anamnesis : Page
    {
        AnamnesisController anamnesisController = new AnamnesisController();
        List<Classes.Model.Anamnesis> anamnesiss = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));

        public Anamnesis()
        {
            InitializeComponent();
            this.DataContext = this;

            List<Classes.Model.Patient> patients = JsonConvert.DeserializeObject<List<Classes.Model.Patient>>(File.ReadAllText("patients2.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patients.Items.Add(pat.jmbg);

            }
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
           
        }


        public void read_AllAnamnesis(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_anamnesis.Items.Clear();
                List<Classes.Model.Anamnesis> anamnesis = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));
                foreach (var anam in anamnesis)
                {
                    lv_anamnesis.Items.Add(anam);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any anamnesis!","Information",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        public void Button_CreateAnamnesis(object sender, RoutedEventArgs e)
        {
            Classes.Model.Anamnesis anamnesis = new Classes.Model.Anamnesis(0,
                                                                            cb_patients.Text,
                                                                            Textbox2.Text,
                                                                            Convert.ToDateTime(datePicker.Text),
                                                                            Textbox3.Text);

            anamnesisController.CreateAnamnesis(anamnesis);
            MessageBox.Show("Anamnesis is successfully created!", "Information", MessageBoxButton.OK,MessageBoxImage.Information);
        }


        private void Button_UpdateAnamnesis(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.Anamnesis anamnesis = new Classes.Model.Anamnesis(Convert.ToInt32(Textbox1.Text),
                                                                                cb_patients.Text,
                                                                                Textbox2.Text,
                                                                                Convert.ToDateTime(datePicker.Text),
                                                                                Textbox3.Text);
                foreach (var a in anamnesiss)
                {
                    if (a.id == Convert.ToInt32(Textbox1.Text))
                    {
                        a.name = anamnesis.name;
                        a.description = anamnesis.description;
                    }
                }
                anamnesisController.UpdateAnamnesis(anamnesis);
                MessageBox.Show("Anamnesis is successfully updated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Select anamnesis to update!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }


        private void Button_ReadAnamnesis(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var app in anamnesiss)
                {
                    if (app.id == Convert.ToInt32(Textbox1.Text))
                    {
                        lv_anamnesis.Items.Clear();
                        lv_anamnesis.Items.Add(app);
                    }
                }
            }
            catch (Exception) { }
        }



        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            cb_patients.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
        }

        private void cb_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void lv_anamnesis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CreateAnamnesis_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CreateAnamnesis_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Classes.Model.Anamnesis anamnesis = new Classes.Model.Anamnesis(0,
                                                                            cb_patients.Text,
                                                                            Textbox2.Text,
                                                                            Convert.ToDateTime(datePicker.Text),
                                                                            Textbox3.Text);

            anamnesisController.CreateAnamnesis(anamnesis);
            MessageBox.Show("Anamnesis is successfully created!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UpdateAnamnesis_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void UpdateAnamnesis_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                Classes.Model.Anamnesis anamnesis = new Classes.Model.Anamnesis(Convert.ToInt32(Textbox1.Text),
                                                                                cb_patients.Text,
                                                                                Textbox2.Text,
                                                                                Convert.ToDateTime(datePicker.Text),
                                                                                Textbox3.Text);
                foreach (var a in anamnesiss)
                {
                    if (a.id == Convert.ToInt32(Textbox1.Text))
                    {
                        a.name = anamnesis.name;
                        a.description = anamnesis.description;
                    }
                }
                anamnesisController.UpdateAnamnesis(anamnesis);
                MessageBox.Show("Anamnesis is successfully updated!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Select anamnesis to update!"); }
        }

          private void ClearFields_CanExecute(object sender, CanExecuteRoutedEventArgs e)
          {
              e.CanExecute = true;
          }

          private void ClearFields_Executed(object sender, ExecutedRoutedEventArgs e)
          {
              Textbox1.Text = " ";
              cb_patients.Text = " ";
              Textbox2.Text = " ";
              Textbox3.Text = " ";
          }
        

        private void SeeAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SeeAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                lv_anamnesis.Items.Clear();
                List<Classes.Model.Anamnesis> anamnesis = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));
                foreach (var anam in anamnesis)
                {
                    lv_anamnesis.Items.Add(anam);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any anamnesis", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SeeOne_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SeeOne_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            {
                try
                {
                    foreach (var app in anamnesiss)
                    {
                        if (app.id == Convert.ToInt32(Textbox1.Text))
                        {
                            lv_anamnesis.Items.Clear();
                            lv_anamnesis.Items.Add(app);
                        }
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
