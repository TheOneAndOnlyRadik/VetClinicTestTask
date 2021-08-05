using Microsoft.EntityFrameworkCore;

namespace VetClinicTestTask.WebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PerformedService> PerformedServices { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
    }
}
