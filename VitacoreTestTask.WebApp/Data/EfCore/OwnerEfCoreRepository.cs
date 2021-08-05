using Microsoft.EntityFrameworkCore;
using System.Linq;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class OwnerEfCoreRepository : EfCoreRepository<Owner, AppDbContext>
    {
        public OwnerEfCoreRepository(AppDbContext context) 
            : base(context) { }

        protected override IQueryable<Owner> QueryableSet
            => base.QueryableSet
                .Include(o => o.Pets);
    }
}
