using System.ComponentModel.DataAnnotations;

namespace DynamicButtonsPOC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
