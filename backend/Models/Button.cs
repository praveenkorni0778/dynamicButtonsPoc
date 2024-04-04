using System.ComponentModel.DataAnnotations;

namespace DynamicButtonsPOC.Models
{
    public class Button
    {
        [Key]
        public int Id { get; set; }
        public string? DisplayName { get; set; }
        public string? Action { get; set; }
        public string? Type { get; set; }
    }
}
