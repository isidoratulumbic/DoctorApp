using SIMSKT3.View.Doctor;
using System.Windows;
using Classes.Controller;

namespace SIMSKT3
{

    public partial class MainWindow : Window
    {
        RenovationController renovationController = new RenovationController();
        public MainWindow()
        {
            InitializeComponent();
            renovationController.ExecuteRenovationAction();
        }

        private void Button_ClickOptionsSecretary(object sender, RoutedEventArgs e)
        {
            //Help secretary = new Help();
            //secretary.Show();
            //this.Close();
        }

        private void Button_ClickDoctor(object sender, RoutedEventArgs e)
        {
            LogInDoctor logDr = new LogInDoctor();
            logDr.Show();
            this.Close();
        }

        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_ClickDirector(object sender, RoutedEventArgs e)
        {
          //  OptionsDirector options = new OptionsDirector();
          //   options.Show();
        }

        private void Button_ClickPatient(object sender, RoutedEventArgs e)
        {
            //Patient patient = new Patient();
           // patient.Show();
            this.Close();
        }
    }
}
