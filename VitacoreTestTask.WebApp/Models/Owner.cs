using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Хозяин"
    /// </summary>
    public class Owner : Person, IEntity
    {
        public long Id { get; set; }

        [NotMapped]
        public string NamesOfPets => string.Join(", ", Pets.Select(p => p.Name));

        // Nav prop
        public ICollection<Pet> Pets { get; set; }
    }
}