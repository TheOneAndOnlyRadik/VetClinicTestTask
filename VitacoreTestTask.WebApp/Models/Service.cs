using System.ComponentModel.DataAnnotations.Schema;
using VetClinicTestTask.WebApp.Data;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Сущность "Услуга"
    /// </summary>
    public class Service: IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
