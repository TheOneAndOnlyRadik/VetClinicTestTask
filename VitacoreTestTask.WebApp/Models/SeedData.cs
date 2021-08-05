using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VetClinicTestTask.WebApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Specialization sl1 = new Specialization { Name = "Зоопсихолог" };
            Specialization sl2 = new Specialization { Name = "Ветеринарный фельдшер" };
            Specialization sl3 = new Specialization { Name = "Фелинолог" };
            Specialization sl4 = new Specialization { Name = "Ветеринарный хирург" };

            Doctor d1 = new Doctor
            {
                FirstName = "Константин",
                LastName = "Котов",
                Gender = Gender.Male,
                Specialization = sl1
            };
            Doctor d2 = new Doctor
            {
                FirstName = "Тимофей",
                LastName = "Никитин",
                Gender = Gender.Male,
                Specialization = sl2
            };
            Doctor d3 = new Doctor
            {
                FirstName = "Елизавета",
                LastName = "Еремина",
                Gender = Gender.Female,
                Specialization = sl3
            };
            Doctor d4 = new Doctor
            {
                FirstName = "Максим",
                LastName = "Зорин",
                Gender = Gender.Male,
                Specialization = sl4,
            };

            Owner o1 = new Owner
            {
                FirstName = "Артём",
                LastName = "Матвеев",
                Gender = Gender.Male
            };
            Owner o2 = new Owner
            {
                FirstName = "Алиса",
                LastName = "Гончарова",
                Gender = Gender.Female
            };
            Owner o3 = new Owner
            {
                FirstName = "Фёдор",
                LastName = "Мартынов",
                Gender = Gender.Male
            };

            Species sc1 = new Species { Name = "Кот/кошка" };
            Species sc2 = new Species { Name = "Собака" };

            Pet p1 = new Pet
            {
                Name = "Барсик",
                Gender = Gender.Male,
                Age = 3,
                Species = sc1,
                Owner = o1
            };
            Pet p2 = new Pet
            {
                Name = "Снежинка",
                Gender = Gender.Female,
                Age = 2,
                Species = sc1,
                Owner = o2
            };
            Pet p3 = new Pet
            {
                Name = "Тузик",
                Gender = Gender.Male,
                Age = 4,
                Species = sc2,
                Owner = o3
            };
            Pet p4 = new Pet
            {
                Name = "Шарик",
                Gender = Gender.Male,
                Age = 2,
                Species = sc2,
                Owner = o3
            };

            Service sv1 = new Service { Name = "Прививка", Price = 700 };
            Service sv2 = new Service { Name = "Стерилизация", Price = 800 };
            Service sv3 = new Service { Name = "Консультация", Price = 500 };

            PerformedService ps1 = new PerformedService
            {
                Service = sv1,
                Doctor = d2,
                Pet = p1,
                DateTime = DateTime.Now,
                Quantity = 1
            };
            PerformedService ps2 = new PerformedService
            {
                Service = sv3,
                Doctor = d3,
                Pet = p2,
                DateTime = DateTime.Now,
                Quantity = 1
            };
            PerformedService ps3 = new PerformedService
            {
                Service = sv2,
                Doctor = d4,
                Pet = p3,
                DateTime = DateTime.Now,
                Quantity = 1
            };
            PerformedService ps4 = new PerformedService
            {
                Service = sv1,
                Doctor = d2,
                Pet = p4,
                DateTime = DateTime.Now,
                Quantity = 1
            };

            Vaccine v1 = new Vaccine { Name = "От бешенства", IsMandatory = true };
            Vaccine v2 = new Vaccine { Name = "От аденовирусной инфекции", IsMandatory = false };
            Vaccine v3 = new Vaccine { Name = "От ринотрахеита", IsMandatory = false };

            Vaccination vt1 = new Vaccination
            {
                DateTime = DateTime.Today.AddYears(-2),
                Pet = p1,
                Vaccine = v1
            };
            Vaccination vt2 = new Vaccination
            {
                DateTime = DateTime.Today.AddYears(-1),
                Pet = p2,
                Vaccine = v3
            };
            Vaccination vt3 = new Vaccination
            {
                DateTime = DateTime.Today.AddYears(-2),
                Pet = p3,
                Vaccine = v1
            };
            Vaccination vt4 = new Vaccination
            {
                DateTime = DateTime.Today.AddYears(-1),
                Pet = p4,
                Vaccine = v2
            };

            context.Specializations.AddRange(sl1, sl2, sl3, sl4);
            context.Doctors.AddRange(d1, d2, d3, d4);
            context.Owners.AddRange(o1, o2, o3);
            context.Species.AddRange(sc1, sc2);
            context.Pets.AddRange(p1, p2, p3, p4);
            context.Services.AddRange(sv1, sv2, sv3);
            context.PerformedServices.AddRange(ps1, ps2, ps3, ps4);
            context.Vaccines.AddRange(v1, v2, v3);
            context.Vaccinations.AddRange(vt1, vt2, vt3, vt4);

            context.SaveChanges();
        }
    }
}
