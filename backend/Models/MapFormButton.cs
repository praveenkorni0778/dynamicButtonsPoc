using System.ComponentModel.DataAnnotations;

namespace DynamicButtonsPOC.Models
{
    public class MapFormButton
    {
        [Key]
        public int Id { get; set; }
        public int FormId { get; set; }
        public int ButtonId { get; set; }
    }
}
