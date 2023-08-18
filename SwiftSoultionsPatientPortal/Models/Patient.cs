using System;
namespace SwiftSoultionsPatientPortal.Models
{
    public class Patient
    {
        public Patient()
        {
        }
        public int ID { get; set; }
        public int Age { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Medication { get; set; }
        public string Doseage { get; set; }
        public string Doctor_Seen { get; set; }
        public string Doctor_Notes { get; set; }
        public DateOnly Last_Visit_Date { get; set; }
        

    }
    
}
    


