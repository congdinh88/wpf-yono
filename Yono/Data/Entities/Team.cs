using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("Teams",Schema ="Employees")]
    public class Team
    {
        [Key] public int TeamId { get; set; }
        [Required] public string Name {  get; set; }
        [ForeignKey("Department")] public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Employee> Employees { get; set;
    }
}
