using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMSKT3.Service;
using Classes.Model;

namespace SIMSKT3.Controller
{
    class EmergencyController
    {
        EmergencyService emergencyService = new EmergencyService();

        public void delete(int id)
        {
            emergencyService.removePatient(id);
        }

        public Patient readPatient(int id)
        {
            return emergencyService.readPatient(id);
        }

        public List<Patient> getAllPatients()
        {
            return emergencyService.getAllPatients();
        }

        public void DeleteAll()
        {
            emergencyService.DeleteAll();
        }
        public void CreatePatients(Patient patient)
        {
            emergencyService.CreatePatients(patient);
        }

        public void UpdatePatients(Patient patient)
        {
            emergencyService.UpdatePatients(patient);
        }

    }
}
