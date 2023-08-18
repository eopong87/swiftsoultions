using System;
using System.Data;
using Dapper;
using MySqlX.XDevAPI;
using SwiftSoultionsPatientPortal.Models;

namespace SwiftSoultionsPatientPortal
{
    public class PatientRepository : IPatientRepository
    {
        private readonly IDbConnection _conn;

        public PatientRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeletePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _conn.Query<Patient>("SELECT * FROM Patients;");
        }

        public Patient GetPatient(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertPatient(Patient patientToInsert)
        {
            _conn.Execute("INSERT INTO Patient (First_NAME, Last_Name, Address, Medication, Doseage, Last_Visit_Date, Doctor_Seen, Doctor_Notes Age, ID) VALUES (@First_Name, @Last_Name, @Address, @Medication, @ID, @Doseage, @Last_visit_Date, @Doctor_Seen, @Doctors_Notes, @Age,);",
       new
       {
           First_Name = patientToInsert.First_Name,
           Last_Name = patientToInsert.Last_Name,
           ID = patientToInsert.ID,
           Address = patientToInsert.Age,
           Medication = patientToInsert.Medication,
           Doseage = patientToInsert.Doseage,
           Last_Visit_Date = patientToInsert.Last_Visit_Date,
           Doctor_Seen = patientToInsert.Doctor_Seen,
           Doctor_Notes = patientToInsert.Doctor_Notes
       });

        }

        public void UpdatePatient(Patient patient)
        {
            _conn.Execute("UPDATE Patient SET First_Name = @First_Name, Last_Name = @Last_Name, Address = @Address, Medication = @Medication, Doseage = @Doseage, Last_Visit_Date = @Last_Visit_Date, Doctor_seen = @Doctor_Seen, Doctor_Notes = @doctor_Notes, WHERE ID = @id",
         new
         {
             First_Name = patient.First_Name,
             Last_Name = patient.Last_Name,
             Address = patient.Address,
             Medication = patient.Medication,
             Doseage = patient.Doseage,
             Last_Visit_Date = patient.Last_Visit_Date,
             Doctor_Seen = patient.Doctor_Seen,
             Doctors_Notes = patient.Doctor_Notes,
             Age = patient.Age,
             Id = patient.ID,
         });
        }

       
        

        

        
        


    }
}

