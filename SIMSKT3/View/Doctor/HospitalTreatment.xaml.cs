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

    public partial class HospitalTreatment : Page
    {

        HospitalTreatmentController hospitalTreatmentController = new HospitalTreatmentController();
        List<Classes.Model.HospitalTreatment> hospitalTreatments = JsonConvert.DeserializeObject<List<Classes.Model.HospitalTreatment>>(File.ReadAllText("hospitalTreatments.json"));
        List<Classes.Model.Room> rooms = JsonConvert.DeserializeObject<List<Classes.Model.Room>>(File.ReadAllText("rooms.json"));


        public HospitalTreatment()
        {
            InitializeComponent();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
           
        }

        private void ListView_SelectionChangedEO(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_finishedAppointments(object sender, RoutedEventArgs e)
        {
            lv_finishedAppointments.Items.Clear();            
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointments.json"));
            foreach (var a in appointments)
            {
                if (DateTime.Now >= a.date)
                {
                    lv_finishedAppointments.Items.Add(a);
                }
            }
        }

        private void ComboBox_SelectionChangedRooms(object sender, SelectionChangedEventArgs e)
        {
            //List<Classes.Model.Room> rooms = JsonConvert.DeserializeObject<List<Classes.Model.Room>>(File.ReadAllText("rooms.json"));
            //foreach (var room in rooms.ToList())
            //{
            //    cb_rooms.Items.Add(room.name);
            //}
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_AddTreatment(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Model.HospitalTreatment hospitalTreatment = new Classes.Model.HospitalTreatment(0,
                                                                                Textbox1.Text,
                                                                                Convert.ToDateTime(start.Text),
                                                                                Convert.ToDateTime(end.Text),
                                                                                cb_rooms.Text,
                                                                                bed.Text
                                                                                );
                                              
                if (!hospitalTreatmentController.CheckValidDate(hospitalTreatment))
                {
                    MessageBox.Show("Incorrect start or end iput!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (hospitalTreatmentController.CheckForBed(hospitalTreatment))
                {
                    MessageBox.Show("The specified bed is not in this room!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (hospitalTreatmentController.CheckUniqueDate(hospitalTreatment))
                {
                    MessageBox.Show("Another treatment is scheduled in that time!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                hospitalTreatmentController.CreateHospitalTreatment(hospitalTreatment);
                    MessageBox.Show("Treatment is successfully added!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Fill all fields!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_readAllTreatments(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.HospitalTreatment> hospitalTreatments = hospitalTreatmentController.readAll();
            lv_treatments.ItemsSource = hospitalTreatments;
        }

        private void Button_Click_ExtendTreatment(object sender, RoutedEventArgs e)
        {
            Classes.Model.HospitalTreatment hospitalTreatment = new Classes.Model.HospitalTreatment(Convert.ToInt32(id.Text),
                                                                                Textbox1.Text,
                                                                                Convert.ToDateTime(start.Text),
                                                                                Convert.ToDateTime(end.Text),
                                                                                cb_rooms.Text,
                                                                                bed.Text
                                                                                );
            if (!hospitalTreatmentController.CheckValidDate(hospitalTreatment))
            {
                MessageBox.Show("Incorrect start or end iput!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (hospitalTreatmentController.CheckUniqueDate(hospitalTreatment))
            {
                MessageBox.Show("Another treatment is scheduled in that time!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            hospitalTreatmentController.Extend(hospitalTreatment);
            MessageBox.Show("Hospital treatment is successfully extended!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            id.Text = " ";
            Textbox1.Text = " ";
            start.Text = null;
            end.Text = null;
            cb_rooms.Text = " ";
        }

        private void Button_ClickBeds(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_beds.Items.Clear();
                List<Classes.Model.Room> rooms = JsonConvert.DeserializeObject<List<Classes.Model.Room>>(File.ReadAllText("rooms.json"));
                foreach (var room in rooms)
                {
                    if (cb_rooms.Text.Equals(room.name))
                    {
                        List<string> kreveti = new List<string>();
                        string[] kr = Convert.ToString(room.beds).Split(',');
                        foreach (var k in kr)
                        {
                            kreveti.Add(k);
                        }
                        foreach (var kre in kreveti)
                        {
                            lv_beds.Items.Add(kre);
                        }                       
                    }
                }
            }
            catch (Exception) { MessageBox.Show("There is no beds!", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }

        }
            


        private void lv_beds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
