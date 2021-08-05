using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Животное (питомец)" 
    /// </summary>
    public class Pet : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public long SpeciesId { get; set; }
        public long OwnerId { get; set; }

        // Navigation properties
        public Species Species { get; set; }
        public Owner Owner { get; set; }
    }
}
