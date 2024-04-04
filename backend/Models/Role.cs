using System.ComponentModel.DataAnnotations;

namespace DynamicButtonsPOC.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string? RoleName { get; set; }
    }
}
