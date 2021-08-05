using Microsoft.AspNetCore.Mvc;
using VetClinicTestTask.WebApp.Data;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Controllers
{
    public class DoctorsController : CrudController<Doctor>
    {
        private readonly IRepository<Specialization> specializationRepo;

        public DoctorsController(IRepository<Doctor> repository, IRepository<Specialization> specializationRepo)
            : base(repository)
        {
            this.specializationRepo = specializationRepo;
        }

        [Route("[action]")]
        public IActionResult Specializations() => View();

        [HttpPost]
        public IActionResult AddSpecialization(Specialization specialization)
        {
            if (ModelState.IsValid)
                specializationRepo.Add(specialization);

            return RedirectToAction(nameof(Specializations));
        }
    }
}
