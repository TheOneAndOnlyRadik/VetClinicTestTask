using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Доктор"
    /// </summary>
    public class Doctor : Person, IEntity
    {
        public long Id { get; set; }
        public long SpecializationId { get; set; }

        // Nav prop
        public Specialization Specialization { get; set; }
    }
}
