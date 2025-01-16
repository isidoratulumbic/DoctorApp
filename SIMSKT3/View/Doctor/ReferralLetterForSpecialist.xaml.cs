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

    public partial class ReferralLetter : Window
    {
        ReferralLetterForSpecialistController referralLetterForSpecialistController = new ReferralLetterForSpecialistController();
        public ReferralLetter()
        {
            InitializeComponent();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Close();
        }

        private void Button_ClickSeeDoctors(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_doctorsBySpec.Items.Clear();
                List<Classes.Model.Doctor> doctors = JsonConvert.DeserializeObject<List<Classes.Model.Doctor>>(File.ReadAllText("doctors.json"));
                foreach (var dr in doctors)
                {
                    if (dr.specialization.Equals(spec.Text))
                    {
                        lv_doctorsBySpec.Items.Add(dr.id + "\t" + dr.firstName + "\t" + dr.lastName + "\t" + dr.specialization);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any doctor!");
            }
        }

        private void ComboBox_Patients(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.Patient> patients = JsonConvert.DeserializeObject<List<Classes.Model.Patient>>(File.ReadAllText("patients2.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patient.Items.Add(pat.jmbg);

            }
        }

        private void ComboBox_Doctors(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.Doctor> doctors = JsonConvert.DeserializeObject<List<Classes.Model.Doctor>>(File.ReadAllText("doctors.json"));
            foreach (var dr in doctors.ToList())
            {
                if (dr.specialization.Equals(spec.Text))
                {
                    cb_doctor.Items.Add(dr.firstName + " " + dr.lastName);
                }
            }
        }

        private void Button_ClickCreateReferralLetter(object sender, RoutedEventArgs e)
        {
            Classes.Model.ReferralLetter referralLetter = new Classes.Model.ReferralLetter(cb_patient.Text,
                                                                            cb_doctor.Text,
                                                                            reason.Text);

            referralLetterController.CreateReferralLetter(referralLetter);
            MessageBox.Show("Referral letter is successfully created!");
        }

        private void Button_ClickSeeReferralLetters(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_referralLetters.Items.Clear();
                List<Classes.Model.ReferralLetter> referralLetters = JsonConvert.DeserializeObject<List<Classes.Model.ReferralLetter>>(File.ReadAllText("referralLetters.json"));
                foreach (var rl in referralLetters)
                {
                    lv_referralLetters.Items.Add(rl.patientJmbg + "\t" + "To:" + rl.doctor + "\t" + rl.reason);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any referral letter!");
            }
        }


    }
}
