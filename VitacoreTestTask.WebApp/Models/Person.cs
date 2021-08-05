using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinicTestTask.WebApp.Models
{
    /// <summary>
    /// Абстрактный класс "Личность"
    /// </summary>
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        [NotMapped]
        public string FullName => FirstName + " " + LastName;
    }
}
