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
using Newtonsoft.Json;
using SIMSKT3.Controller;
using SIMSKT3.Model;
using SIMSKT3.ViewModel;

namespace SIMSKT3.View.Doctor
{
    /// <summary>
    /// Interaction logic for RequestForDaysOff.xaml
    /// </summary>
    public partial class RequestForDaysOff : UserControl {
            public RequestForDaysOff()
            {
                InitializeComponent();
                this.DataContext = new SIMSKT3.ViewModel.RequestViewModel();
            }

        
    }
    }



