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
    /// <summary>
    /// Interaction logic for LogInDoctor.xaml
    /// </summary>
    public partial class LogInDoctor : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focus();
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
       // private bool KeyPreview;

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

   

        public LogInDoctor()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void Button_ClickDoctor(object sender, RoutedEventArgs e)
        {
            if (username.Text != "lekar" || password.Password != "in45")
            {
                greska.Text = "Incorrect username or password!";
                greska.Foreground = SetRGBColor(255, 0, 0);
            }
            else
            {
                Doctor logDr = new Doctor();
                logDr.Show();
                this.Close();
            }
           
        }

        public System.Windows.Media.Brush SetRGBColor(int red, int green, int blue)
        {
            int R = red;
            int G = green;
            int B = blue;
            var brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)R, (byte)G, (byte)B));
            return brush;
        }

        private void LogIn_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void LogIn_Executed(object sender, ExecutedRoutedEventArgs e)
        {
                if (username.Text != "lekar" || password.Password != "in45")
                {
                    greska.Text = "Incorrect username or password!";
                    greska.Foreground = SetRGBColor(255, 0, 0);
                }
                else
                {
                    Doctor logDr = new Doctor();
                    logDr.Show();
                    this.Close();
                }

            
        }
    }
}