using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory.Data
{
    public class PermissionSets
    {
        [Key]
        public int Id { get; set; }
        public int HasAdmin { get; set; }
    }
}
