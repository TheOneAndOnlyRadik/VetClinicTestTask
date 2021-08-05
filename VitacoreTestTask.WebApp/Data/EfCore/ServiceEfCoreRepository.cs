using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public class ServiceEfCoreRepository : EfCoreRepository<Service, AppDbContext>
    {
        public ServiceEfCoreRepository(AppDbContext context) 
            : base(context) { }
    }
}
