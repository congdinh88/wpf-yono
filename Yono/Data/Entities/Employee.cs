using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("Employees", Schema ="Employee")]
    public class Employee
    {
        [Key] public int EmployeeId { get; set; }
        [Required] public string FullName { get; set; }
        [Required] public DateOnly DateOfBirth { get; set; }
        [ForeignKey("Role")] public int RoleId { get;set; }
        [ForeignKey("Team")] public int TeamId { get; set; }
        public DateOnly ProbasionDate {  get; set; }
        public DateOnly HireDate { get; set; }
        public DateOnly TerminationDate {  get; set; }
        
        public Role Role { get; set; }
        public Team Team { get; set; }
        public ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
