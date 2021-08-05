using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinicTestTask.WebApp.Data;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Controllers
{
    public class OwnersController : CrudController<Owner>
    {
        public OwnersController(IRepository<Owner> repository) : base(repository) { }
    }
}
