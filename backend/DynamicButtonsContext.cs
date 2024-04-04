using Microsoft.EntityFrameworkCore;

namespace DynamicButtonsPOC.Models
{
    public class DynamicButtonsContext: DbContext
    {
        public DynamicButtonsContext(DbContextOptions options) : base(options) { }

        public DbSet<Button> Buttons { get; set; } 
        public DbSet<Form> Forms { get; set; }
        public DbSet<MapButtonRole> MapButtonRole { get; set; }
        public DbSet<MapFormButton> MapFormButton { get; set; }
        public DbSet<MapUserRole> MapUserRole { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
