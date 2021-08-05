using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class VaccineEfCoreRepository : EfCoreRepository<Vaccine, AppDbContext>
    {
        public VaccineEfCoreRepository(AppDbContext context)
            : base(context) { }
    }
}
