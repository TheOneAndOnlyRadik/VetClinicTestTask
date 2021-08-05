using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Специализация врача"
    /// </summary>
    public class Specialization : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
