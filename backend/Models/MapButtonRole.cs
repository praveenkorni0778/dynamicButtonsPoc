using System.ComponentModel.DataAnnotations;

namespace DynamicButtonsPOC.Models
{
    public class MapButtonRole
    {
        [Key]
        public int Id { get; set; }
        public int ButtonId { get; set; }
        public int RoleId { get; set; }
    }
}
