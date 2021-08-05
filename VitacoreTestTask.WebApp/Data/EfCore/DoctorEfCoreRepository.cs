using Microsoft.EntityFrameworkCore;
using System.Linq;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class DoctorEfCoreRepository : EfCoreRepository<Doctor, AppDbContext>
    {
        public DoctorEfCoreRepository(AppDbContext context)
            : base(context) { }

        protected override IQueryable<Doctor> QueryableSet
            => base.QueryableSet
                .Include(d => d.Specialization);
    }
}
