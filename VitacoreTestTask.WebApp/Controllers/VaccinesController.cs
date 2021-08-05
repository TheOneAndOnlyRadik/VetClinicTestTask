using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinicTestTask.WebApp.Data;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Controllers
{
    public class VaccinesController : CrudController<Vaccine>
    {
        public VaccinesController(IRepository<Vaccine> repository)
            : base(repository) { }
    }
}
