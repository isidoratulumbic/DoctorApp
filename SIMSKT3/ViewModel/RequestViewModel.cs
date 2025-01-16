using SIMSKT3.Model;
using SIMSKT3.View.Doctor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSKT3.ViewModel
{
    public class RequestViewModel : BindableBase
    {
        public ObservableCollection<Request> Requests { get; set; }
        private Request currentRequest = new Request();
        public MyICommand AddCommand { get; set; }
        private string idText;
        private string fromText;
        private string toText;
        private string reasonText;

        public RequestViewModel()
        {
            LoadRequests();
            AddCommand = new MyICommand(OnAdd);
        }


        public void LoadRequests()
        {
            ObservableCollection<Request> requests =
                new ObservableCollection<Request>();

            requests.Add(new Request { Id = "1", From = "25/05/2022", To = "30/05/2022", Reason="Operation", Status="APPROVED", Description="/" });
            requests.Add(new Request { Id = "2", From = "30/05/2022", To = "15/06/2022", Reason = "Holiday", Status = "APPROVED", Description = "/" });
            requests.Add(new Request { Id = "3", From = "30/05/2022", To = "15/06/2022", Reason = "Holiday", Status = "REJECTED", Description = "Busy term" });
            Requests = requests;
        }



        public string IDText
        {
            get { return idText; }
            set
            {
                if (idText != value)
                {
                    idText = value;
                    OnPropertyChanged("IDText");
                }
            }
        }

        public string FROMText
        {
            get { return fromText; }
            set
            {
                if (fromText != value)
                {
                    fromText = value;
                    OnPropertyChanged("LNText");
                }
            }
        }
        public string TOText
        {
            get { return toText; }
            set
            {
                if (toText != value)
                {
                    toText = value;
                    OnPropertyChanged("TOText");
                }
            }
        }

        public string REASONText
        {
            get { return reasonText; }
            set
            {
                if (reasonText != value)
                {
                    reasonText = value;
                    OnPropertyChanged("REASONText");
                }
            }
        }

        public Request CurrentRequest
        {
            get { return currentRequest; }
            set
            {
                currentRequest = value;
                OnPropertyChanged("CurrentRequest");
            }
        }
        private void OnAdd()
        {
          //  CurrentRequest.Validate();
           // if (CurrentRequest.IsValid)
           // {
                Requests.Add(new Request { Id = IDText, From = FROMText, To = TOText, Reason = REASONText });
          //  }
        }
    }
}