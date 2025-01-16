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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SIMSKT3.View.Doctor
{
    /// <summary>
    /// Interaction logic for Examination.xaml
    /// </summary>
    public partial class Examination : Page
    {


        public List<Examination> examinations = new List<Examination>();



        public Examination()
        {
            InitializeComponent();
            this.DataContext = this;

        }



        private void read_all(object sender, RoutedEventArgs e)
        {
            lv_examination.Items.Clear();
            List<SIMSKT3.Model.Examination> examinations = JsonConvert.DeserializeObject<List<SIMSKT3.Model.Examination>>(File.ReadAllText("Appoint.json"));
            foreach (var exam in examinations)
            {
                lv_examination.Items.Add(exam);
            }
        }

        private void viewReport(object sender, RoutedEventArgs e)
        {
            try
            {
                DateInterval rep = new DateInterval();
                rep.Show();
                //this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Select patient first!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
    

