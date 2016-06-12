using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseInventory.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int PermissionSetID { get; set; }

        [ForeignKey("PermissionSetId")]
        public virtual IEnumerable<PermissionSet> Permissionsets { get; set; }
    }
}