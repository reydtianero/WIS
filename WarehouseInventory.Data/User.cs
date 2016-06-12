using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int  PermissionSetID { get; set; }
        public string Password { get; set; }

        [ForeignKey("PermissionSetId")]
        public virtual PermissionSets Permissionsets { get; set; }
    }   
}
