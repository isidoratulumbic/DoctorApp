
using System;

namespace Classes.Model
{
    public class Employee : User
    {
         
        public int salary;
        public System.TimeSpan workingHours;
        public System.TimeSpan annualVacation;
        public EmployeeType role;

        public User user;
        public Room room;
        public Warehouse warehouse;
        public System.Collections.Generic.List<MedicalRecord> medicalRecord;



        public int id;
        public String username;
        public String address;
        public String firstName;
        public String lastName;
        public String dateOfBirth;
        public String jmbg;
        public String hospital;
        public string phoneNumber;
        //public EmployeeRole employeeRole;


        public Employee() { }

        public Employee(int id, String username, String address, String firstName, String lastName, String dateOfBirth, string jmbg, string hospital, string phoneNumber/*EmployeeRole employeeRole*/)
        {
            this.id = id;
            this.username = username;
            this.address = address;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.jmbg = jmbg;
            this.hospital = hospital;
            this.phoneNumber = phoneNumber;
            //this.employeeRole = employeeRole;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }

        public string Address { get => address; set => address = value; }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string JMBG { get => jmbg; set => jmbg = value; }

        public string Hospital { get => hospital; set => hospital = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        //public EmployeeRole EmployeeRole { get => employeeRole; set => employeeRole = value; }


        /// <summary>
        /// Property for collection of MedicalRecord
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>


        /// <summary>
        /// Add a new MedicalRecord in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>


        /// <summary>
        /// Remove an existing MedicalRecord from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>


        /// <summary>
        /// Remove all instances of MedicalRecord from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>

        /// <summary>
        /// Property for collection of Appointment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>


        /// <summary>
        /// Add a new Appointment in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>


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