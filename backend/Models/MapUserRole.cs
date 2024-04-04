using System.ComponentModel.DataAnnotations;

namespace DynamicButtonsPOC.Models
{
    public class MapUserRole
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
