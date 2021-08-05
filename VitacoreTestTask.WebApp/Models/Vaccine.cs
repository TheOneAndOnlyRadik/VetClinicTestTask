using System.Collections.Generic;
using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Прививка"
    /// </summary>
    public class Vaccine : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsMandatory { get; set; }
    }
}
