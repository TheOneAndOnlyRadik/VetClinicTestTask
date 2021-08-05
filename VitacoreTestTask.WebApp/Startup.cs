using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VetClinicTestTask.WebApp.Data;
using VetClinicTestTask.WebApp.Data.EfCore;
using VetClinicTestTask.WebApp.Models;

namespace VetClinicTestTask.WebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddDbContext<AppDbContext>(opts =>
            {
                opts.UseNpgsql(Configuration.GetConnectionString("VetClinicPostgres"));
            });

            services.AddScoped<IRepository<Doctor>, DoctorEfCoreRepository>();
            services.AddScoped<IRepository<Owner>, OwnerEfCoreRepository>();
            services.AddScoped<IRepository<PerformedService>, PerformedServiceEfCoreRepository>();
            services.AddScoped<IRepository<Pet>, PetEfCoreRepository>();
            services.AddScoped<IRepository<Service>, ServiceEfCoreRepository>();
            services.AddScoped<IRepository<Specialization>, SpecializationEfCoreRepository>();
            services.AddScoped<IRepository<Species>, SpeciesEfCoreRepository>();
            services.AddScoped<IRepository<Vaccination>, VaccinationEfCoreRepository>();
            services.AddScoped<IRepository<Vaccine>, VaccineEfCoreRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedData.EnsurePopulated(app);
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
