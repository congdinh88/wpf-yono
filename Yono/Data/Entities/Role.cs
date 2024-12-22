using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("Roles", Schema ="Employee")]
    public class Role
    {
        [Key] public int RoleId {  get; set; }
        [Required] public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
