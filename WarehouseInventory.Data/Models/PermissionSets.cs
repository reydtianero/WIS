using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarehouseInventory.Data
{
    public class PermissionSet
    {
        [Key]
        public int Id { get; set; }

        public int IsAdmin { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}