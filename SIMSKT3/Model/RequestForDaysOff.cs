using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSKT3.Model
{

    /*    public class Request
        {
            public Request(string id, string from, string to, string reason, string status, string description)
            {
                this.Id = id;
                this.From = from;
                this.To = to;
                this.Reason = reason;
                this.Status = status;
                this.Description = description;
            }

            public string Id { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public string Reason { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }

        }

        public class RequestHandler
        {
            public RequestHandler()
            {
                Requests = new List<Request>();
            }

            public List<Request> Requests { get; private set; }

            public void Add(Request request)
            {
                Requests.Add(request);
            }
        }

        public class RequestViewModel
        {
            private readonly RequestHandler _requestHandler;

            public RequestViewModel()
            {
                _requestHandler = new RequestHandler();
                _requestHandler.Add(new Request("1", "12/05/2022", "20/05/2022","Godisnji odmor", "APPROVED",""));
                _requestHandler.Add(new Request("2", "18/07/2022", "25/07/2022", "Razlog", "REJECTED", "Razlog odbijanja"));

            }

            public List<Request> Requests
            {
                get { return _requestHandler.Requests; }
            }
        }*/

    /*proba*/

    public class RequestModel
    {
    }

    public class Request : INotifyPropertyChanged 
    {
        private string id;
        private string from;
        private string to;
        private string reason;
        private string status;
        private string description;

        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("Id");
                 
                }
            }
        }

        public string From
        {
            get { return from; }
            set
            {
                if (from != value)
                {
                    from = value;
                    RaisePropertyChanged("From");
                  
                }
            }
        }
        public string To
        {
            get { return to; }
            set
            {
                if (to != value)
                {
                    to = value;
                    RaisePropertyChanged("To");
                   
                }
            }
        }

        internal void Validate()
        {
            throw new NotImplementedException();
        }

        public string Reason
        {
            get { return reason; }
            set
            {
                if (reason != value)
                {
                    reason = value;
                    RaisePropertyChanged("Reason");
                
                }
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("Status");
                 
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("Description");
                
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
    /*
    protected override void ValidateSelf()
    {
        if (string.IsNullOrWhiteSpace(this.id))
        {
            this.ValidationErrors["Id"] = "Id is required.";
        }
        if (string.IsNullOrWhiteSpace(this.from))
        {
            this.ValidationErrors["From"] = "Start date cannot be empty.";
        }
    }*/

}
