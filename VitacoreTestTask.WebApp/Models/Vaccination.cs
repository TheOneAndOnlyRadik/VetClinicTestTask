using System;
using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    public class Vaccination : IEntity
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public long PetId { get; set; }
        public long VaccineId { get; set; }

        // Nav props
        public Pet Pet { get; set; }
        public Vaccine Vaccine { get; set; }
    }
}
