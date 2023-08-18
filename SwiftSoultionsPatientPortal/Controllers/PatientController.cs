using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwiftSoultionsPatientPortal.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwiftSoultionsPatientPortal.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository repo;

        public PatientController(IPatientRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var Patients = repo.GetAllPatients();
            return View(Patients);
        }
        public IActionResult ViewPatient(int id)
        {
            var patient = repo.GetPatient(id);
            return View(patient);
        }
        public IActionResult UpdatePatient(int id)
        {
            Patient client = repo.GetPatient(id);
            if (client == null)
            {
                return View("PatientNotFound");
            }
            return View(client);
        }
        public IActionResult UpdatePatientToDatabase(Patient patient)
        {
            repo.UpdatePatient(patient);

            return RedirectToAction("ViewPatient", new { id = patient.ID });
        }
        public IActionResult DeletePatient(Patient patient)
        {
            repo.DeletePatient(patient);
            return RedirectToAction("Index");
        }
        public IActionResult InsertPatientToDatabase(Patient patient)
        {
            repo.InsertPatient(patient);
            return RedirectToAction("Index");
        }

    }
}


