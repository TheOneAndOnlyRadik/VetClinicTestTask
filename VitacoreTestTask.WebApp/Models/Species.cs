using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Вид животного"
    /// </summary>
    public class Species : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}