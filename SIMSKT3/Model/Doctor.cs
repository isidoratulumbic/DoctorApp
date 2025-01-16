using System;
using System.Collections.Generic;
namespace Classes.Model
{
    public class Doctor : Employee
    {

        public string specialization { get; set; }
        public string onOffDays;
        public string explenation { get; set; }
        public string workHours { get; set; }
        public string startOffDays;
        public string endOffDays;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }
        public string jmbg { get; set; }

        public Doctor(int id, string firstName, string lastName, string jmbg, string specialization, string onOffDays, string startOffDays, string endOffDays, string explenation)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jmbg = jmbg;
            this.specialization = specialization;
            this.onOffDays = onOffDays;
            this.startOffDays = startOffDays;
            this.endOffDays = endOffDays;
            this.explenation = explenation;
        }

        public Doctor()
        {
        }

        public System.Collections.ArrayList appointment;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JMBG { get => jmbg; set => jmbg = value; }

        public string Specialization { get => specialization; set => specialization = value; }
        
        public string StartOffDays { get => startOffDays; set => startOffDays = value; }
        public string EndOffDays { get => endOffDays; set => endOffDays = value; }
        public string OnffDays { get => onOffDays; set => onOffDays = value; }
        public string Explenation { get => explenation; set => explenation = value; }


        /// <summary>
        /// Property for collection of Appointment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>



        /// <summary>
        /// Remove an existing Appointment from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>


        /// <summary>
        /// Remove all instances of Appointment from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>


    }
}