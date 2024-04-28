using System.ComponentModel.DataAnnotations;

namespace PlatformSerice.Models
{
    public class Platform
    {
        [Key] // Первичный ключ в БД
        [Required] // Обязательное поле
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
