using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    
    public partial class Report : Window, INotifyPropertyChanged
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


        public Report()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Close();
        }

        private void Button_ClickPrint(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Close();
        }
    }
}
