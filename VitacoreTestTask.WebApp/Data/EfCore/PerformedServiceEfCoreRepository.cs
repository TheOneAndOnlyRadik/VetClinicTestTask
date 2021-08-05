using Microsoft.EntityFrameworkCore;
using System.Linq;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class PerformedServiceEfCoreRepository : EfCoreRepository<PerformedService, AppDbContext>
    {
        public PerformedServiceEfCoreRepository(AppDbContext context)
            : base(context) { }

        protected override IQueryable<PerformedService> QueryableSet
            => base.QueryableSet
                .Include(p => p.Doctor)
                .Include(p => p.Pet)
                .Include(p => p.Service);
    }
}
