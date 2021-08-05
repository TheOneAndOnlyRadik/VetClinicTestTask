using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using VetClinicTestTask.WebApp.Data;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Infrastructure
{
    public static class SelectListExtensions
    {
        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Specialization> specializationRepo)
        {
            return specializationRepo.GetAll()
                .Select(s => new SelectListItem(s.Name, s.Id.ToString()));
        }

        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Species> speciesRepo)
        {
            return speciesRepo.GetAll()
                .Select(s => new SelectListItem(s.Name, s.Id.ToString()));
        }

        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Owner> ownerRepo)
        {
            return ownerRepo.GetAll()
                .Select(o => new SelectListItem(o.FullName, o.Id.ToString()));
        }

        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Service> serviceRepo)
        {
            return serviceRepo.GetAll()
                .Select(s => new SelectListItem(s.Name, s.Id.ToString()));
        }

        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Pet> petRepo)
        {
            return petRepo.GetAll()
                .Select(p => new SelectListItem(p.Name, p.Id.ToString()));
        }

        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Doctor> doctorRepo)
        {
            return doctorRepo.GetAll()
                .Select(d => new SelectListItem(d.FullName, d.Id.ToString()));
        }

        public static IEnumerable<SelectListItem> GetSelectList(this IRepository<Vaccine> vaccineRepo)
        {
            return vaccineRepo.GetAll()
                .Select(p => new SelectListItem(p.Name, p.Id.ToString()));
        }
    }
}
