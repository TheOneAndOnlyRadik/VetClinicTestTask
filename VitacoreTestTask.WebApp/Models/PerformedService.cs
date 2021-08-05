using System;
using System.ComponentModel.DataAnnotations.Schema;
using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Оказанная услуга"
    /// </summary>
    public class PerformedService : IEntity
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }

        /// <value> Количественная метрика услуги </value>
        public int Quantity { get; set; }

        public long ServiceId { get; set; }
        public long PetId { get; set; }
        public long DoctorId { get; set; }

        [NotMapped]
        public decimal TotalPrice => Service.Price * Quantity;

        // Nav props
        public Service Service { get; set; }
        public Pet Pet { get; set; }
        public Doctor Doctor { get; set; }
    }
}
