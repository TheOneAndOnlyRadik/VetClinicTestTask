using Microsoft.AspNetCore.Mvc;
using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Controllers
{
    [Route("[controller]")]
    public abstract class CrudController<T> : Controller
        where T : class, IEntity
    {
        protected IRepository<T> Repository { get; }

        protected CrudController(IRepository<T> repository)
        {
            Repository = repository;
        }

        //[Route("[action]/{id}")]
        //public virtual IActionResult Details(long id) => View(Repository.Get(id));

        [Route("[action]")]
        public virtual IActionResult List() => View(Repository.GetAll());

        [HttpGet]
        [Route("[action]")]
        public virtual IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("ModelInput");
        }

        [HttpPost]
        [Route("[action]")]
        public virtual IActionResult Add(T model)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return RedirectToActionPermanent(nameof(List));
            }

            return View("ModelInput", model);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public virtual IActionResult Edit(long id)
        {
            ViewBag.Action = "Update";
            return View("ModelInput", Repository.Get(id));
        }

        [HttpPost]
        [Route("[action]")]
        public virtual IActionResult Update(T model)
        {
            if (ModelState.IsValid)
            {
                Repository.Update(model);
                return RedirectToActionPermanent(nameof(List));
            }

            return View("ModelInput", model);
        }

        [HttpPost]
        [Route("[action]")]
        public virtual IActionResult Delete(long id)
        {
            T item = Repository.Get(id);
            if (item != null)
                Repository.Delete(id);

            return RedirectToActionPermanent(nameof(List));
        }
    }
}
