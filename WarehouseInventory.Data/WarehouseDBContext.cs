using System.Data.Entity;

namespace WarehouseInventory.Data
{
    public class WarehouseDBContext : DbContext
    {
        public WarehouseDBContext()
            : base("WarehouseInventory")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<WarehouseDBContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WarehouseDBContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PermissionSet> PermisionSets { get; set; }
    }
}