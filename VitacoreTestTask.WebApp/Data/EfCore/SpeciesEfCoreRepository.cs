using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class SpeciesEfCoreRepository : EfCoreRepository<Species, AppDbContext>
    {
        public SpeciesEfCoreRepository(AppDbContext context)
            : base(context) { }
    }
}
