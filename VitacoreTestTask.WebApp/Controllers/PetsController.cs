using Microsoft.AspNetCore.Mvc;
using VetClinicTestTask.WebApp.Data;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Controllers
{
    public class PetsController : CrudController<Pet>
    {
        private readonly IRepository<Species> speciesRepo;

        public PetsController(IRepository<Pet> repository, IRepository<Species> speciesRepo) 
            : base(repository)
        {
            this.speciesRepo = speciesRepo;
        }

        [Route("[action]")]
        public IActionResult Species() => View();

        public IActionResult AddSpecies(Species model)
        {
            if(ModelState.IsValid)
                speciesRepo.Add(model);

            return RedirectToAction(nameof(Species));
        }
    }
}
