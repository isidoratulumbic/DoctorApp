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
    public partial class ReferralLetter : Page, INotifyPropertyChanged
    {
        
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public string time { get; set; }
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





        ReferralLetterForSpecialistController referralLetterForSpecialistController = new ReferralLetterForSpecialistController();
        public ReferralLetter()
        {
            InitializeComponent();
            this.DataContext = this;

            List<Classes.Model.Patient> patients = JsonConvert.DeserializeObject<List<Classes.Model.Patient>>(File.ReadAllText("patients2.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patient.Items.Add(pat.jmbg);

            }

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
           
        }

        private void Button_ClickSeeDoctors(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_doctorsBySpec.Items.Clear();
                List<Classes.Model.Doctor> doctors = JsonConvert.DeserializeObject<List<Classes.Model.Doctor>>(File.ReadAllText("doctorss.json"));
                foreach (var dr in doctors)
                {
                    if (dr.specialization.Equals(cb_doctors.Text))
                    {
                        //lv_doctorsBySpec.Items.Add(dr.id + "\t" + dr.firstName + "\t" + dr.lastName + "\t" + dr.specialization);
                        lv_doctorsBySpec.Items.Add(dr);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any doctor!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void ComboBox_Patients(object sender, SelectionChangedEventArgs e)
        {
            
        }

        

        private void Button_ClickCreateReferralLetter(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.ReferralLetterForSpecialist referralLetter = new Classes.Model.ReferralLetterForSpecialist(
                                                                                                            0,
                                                                                                            cb_patient.Text,
                                                                                                            doctor.Text,
                                                                                                            reason.Text,
                                                                                                            cb_type.Text,
                                                                                                            Convert.ToDateTime(Datepicker.Text),
                                                                                                            Convert.ToDateTime(Textbox2.Text), 
                                                                                                            Convert.ToDateTime(Textbox3.Text) 
                                                                                                            );
                if (cb_type.Text.Equals("Operation"))
                {
                    referralLetterForSpecialistController.CreateReferralOperation(referralLetter);
                }
                else
                    if (cb_type.Text.Equals("Examination"))
                {
                    referralLetterForSpecialistController.CreateReferralExamination(referralLetter);
                }
                else
                    if (cb_type.Text.Equals("Admition"))
                {
                    referralLetterForSpecialistController.CreateReferralAdmition(referralLetter);
                }
                MessageBox.Show("Referral letter is successfully created!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception) { MessageBox.Show("Fill all fields!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void Button_ClickSeeReferralLetters(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_referralLetters.Items.Clear();
                List<Classes.Model.ReferralLetterForSpecialist> referralLetters = JsonConvert.DeserializeObject<List<Classes.Model.ReferralLetterForSpecialist>>(File.ReadAllText("referralLetters.json"));
                foreach (var rl in referralLetters)
                {
                    lv_referralLetters.Items.Add(rl);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any referral letter!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void cb_doctors_SelectionChangedDoctors(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
