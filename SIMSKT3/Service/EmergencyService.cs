using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMSKT3.Repository;
using Classes.Model;
using Classes.Repository;

namespace SIMSKT3.Service
{
    class EmergencyService
    {


        EmergencyRepository emergencyRepository = new EmergencyRepository();
        public void removePatient(int id)
        {
            emergencyRepository.deletePatientFromStorage(id);
        }

        public Patient readPatient(int id)
        {
            return emergencyRepository.readPatient(id);
        }

        public List<Patient> getAllPatients()
        {
            return emergencyRepository.getAllPatients();
        }
        public void DeleteAll()
        {
            emergencyRepository.DeleteAll();
        }

        public void CreatePatients(Patient patient)
        {
            emergencyRepository.CreatePatients(patient);
        }

        public void UpdatePatients(Patient patient)
        {
            emergencyRepository.UpdatePatients(patient);
        }

        public void checkPatientJmbgForEmergency()
        {

        }
    }

}
