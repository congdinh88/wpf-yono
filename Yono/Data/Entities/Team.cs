using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("Teams",Schema ="Employee")]
    public class Team
    {
        [Key] public string TeamId { get; set; }
        [Required] public string Name {  get; set; }
        [Required] [ForeignKey("Department")] public string DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
