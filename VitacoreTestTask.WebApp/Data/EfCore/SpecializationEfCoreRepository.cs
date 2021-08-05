using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class SpecializationEfCoreRepository: EfCoreRepository<Specialization, AppDbContext>
    {
        public SpecializationEfCoreRepository(AppDbContext context)
            : base(context) { }
    }
}
