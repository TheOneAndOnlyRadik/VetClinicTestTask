using Microsoft.EntityFrameworkCore;
using System.Linq;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class PetEfCoreRepository : EfCoreRepository<Pet, AppDbContext>
    {
        public PetEfCoreRepository(AppDbContext context)
            : base(context) { }

        protected override IQueryable<Pet> QueryableSet
            => base.QueryableSet
                .Include(p => p.Species)
                .Include(p => p.Owner);
    }
}
