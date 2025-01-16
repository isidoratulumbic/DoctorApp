using Classes.Controller;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace SIMSKT3.View.Doctor
{

    public partial class Appointment : Page, INotifyPropertyChanged
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
        App app;
        AppointmentController appointmentController = new AppointmentController();
        List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointments.json"));
        public Appointment()
        {
            InitializeComponent();
            this.DataContext = this;

            cb_patients.SelectedValue = "Choose patient";
            List<Classes.Model.Patient> patients = JsonConvert.DeserializeObject<List<Classes.Model.Patient>>(File.ReadAllText("patients2.json"));
            foreach (var p in patients.ToList())
            {
                cb_patients.Items.Add(p.jmbg);
            }

            List<Classes.Model.StaticEquipment> seq = JsonConvert.DeserializeObject<List<Classes.Model.StaticEquipment>>(File.ReadAllText("staticequipment.json"));

            foreach (var se in seq.ToList())
            {
                if (se.typeOdStaticEquipment.Equals(equipment.Text))
                {
                    cb_rooms.Items.Add(se.roomName + " " + se.typeOdStaticEquipment);
                }
            }

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor win = new Doctor();
            win.Show();
           
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
            Datepicker.Text = null;
            cb_patients.Text = " ";
            cb_type.Text = " ";
            cb_rooms.Text = " ";
            equipment.Text = " ";
        }


        public void Button_Create(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.Appointment apps = new Classes.Model.Appointment(0, cb_type.Text, Convert.ToDateTime(Textbox2.Text), Convert.ToDateTime(Textbox3.Text), Convert.ToDateTime(Datepicker.Text), cb_patients.Text, null, null, cb_rooms.Text, false);

                if (apps.appointmentType.Equals("Examination"))
                {
                    apps.roomName = "DOCTORS ROOM";
                }

                if (appointmentController.CheckForInvalidInput(apps))
                {
                    MessageBox.Show("Appointment can't be scheduled in the past. Check for correct time input," +
                        " start time must be before end time!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (appointmentController.AppointmentBusy(apps))
                {
                    MessageBox.Show("The appointment is busy! Change time!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                if (appointmentController.AppointmentBusyByRenovation(apps))
                {
                    MessageBox.Show("Appointment is busy because renovation is scheduled at the same time!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                appointmentController.CreateAppointment(apps);
                MessageBox.Show("Appointment is successfully created!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Fill all fields or check for valid input!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lv_appointments.Items.Clear();
            MessageBox.Show("All appointments are successfully deleted!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        public void read_all(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_appointments.Items.Clear();
                List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointments.json"));
                foreach (var appointment in appointments)
                {
                    lv_appointments.Items.Add(appointment);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any appointment!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.Appointment apps = new Classes.Model.Appointment(Convert.ToInt32(Textbox1.Text), cb_type.Text, Convert.ToDateTime(Textbox2.Text), Convert.ToDateTime(Textbox3.Text), Convert.ToDateTime(Datepicker.Text), cb_patients.Text, null, null, cb_rooms.Text, false);

                if (appointmentController.CheckForInvalidInput(apps))
                {
                    MessageBox.Show("Time is not in valid format or endTime is before startTime!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (appointmentController.AppointmentBusyByRenovation(apps))
                {
                    MessageBox.Show("Appointment is busy because renovation is scheduled at the same time!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (appointmentController.AppointmentBusy(apps))
                {
                    MessageBox.Show("Appointment is busy! Change time!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                foreach (var a in appointments)
                {
                    if (a.id == Convert.ToInt32(Textbox1.Text))
                    {
                        a.startTime = apps.startTime;
                        a.endTime = apps.endTime;
                        a.date = apps.date;
                        a.roomName = apps.roomName;
                        appointmentController.UpdateAppointment(apps);
                        MessageBox.Show("Appointment is successfully updated", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Select appointment first!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var app in appointments)
                {
                    if (app.id == Convert.ToInt32(Textbox1.Text))
                    {
                        lv_appointments.Items.Clear();
                        lv_appointments.Items.Add(app);
                    }
                }
            }
            catch (Exception) { }
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            try
            {
                appointmentController.DeleteAppointment(Convert.ToInt32(Textbox1.Text));
                MessageBox.Show("Appointment is successfully deleted!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Select appointment first!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void lv_appointments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_rooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_ViewPatientInfo(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var a in appointments)
                {

                    if (a.id.Equals(Convert.ToInt32(Textbox1.Text)))
                    {
                        lv_viewpatients.Items.Clear();
                        lv_viewpatients.Items.Add(a.patientJmbg);
                       // lv_viewpatients.Item.Add(a.)
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select appointment to view patient's information!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void lv_viewpatients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_DEMO(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = "3";
            Textbox2.Text = "12:30";
            Textbox3.Text = "13:00";
            Datepicker.Text = "10/05/2022";
            cb_patients.Text = "327423 ";
            cb_type.Text = "EXAMINATION";
            cb_rooms.Text = " ";
            equipment.Text = " ";
        }

    }


  
}
