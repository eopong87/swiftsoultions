using System;
using System.Collections.Generic;
using SwiftSoultionsPatientPortal.Models;

namespace SwiftSoultionsPatientPortal
{
    public interface IPatientRepository
    {
        public void InsertPatient(Patient patientToInsert);
        public void UpdatePatient(Patient patient);
        public IEnumerable<Patient> GetAllPatients();
        public Patient GetPatient(int id);
        public void DeletePatient(Patient patient);
    }
}




   
   

