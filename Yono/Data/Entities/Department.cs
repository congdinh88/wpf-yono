using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("Departments", Schema ="Employee")]
    public class Department
    {
        [Key] public int DepartmentId { get; set; }
        [Required] public string Name {  get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
