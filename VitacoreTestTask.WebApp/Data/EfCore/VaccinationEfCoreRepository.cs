using Microsoft.EntityFrameworkCore;
using System.Linq;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class VaccinationEfCoreRepository : EfCoreRepository<Vaccination, AppDbContext>
    {
        public VaccinationEfCoreRepository(AppDbContext context)
            : base(context) { }

        protected override IQueryable<Vaccination> QueryableSet
            => base.QueryableSet
                .Include(v => v.Pet)
                .Include(v => v.Vaccine);
    }
}
