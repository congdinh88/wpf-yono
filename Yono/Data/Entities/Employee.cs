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
        [Key] public string EmployeeId { get; set; }
        [Required] public string FullName { get; set; }
        [Required] public DateOnly DateOfBirth { get; set; }
        [Required] [ForeignKey("Role")] public string RoleId { get;set; }
        [Required] [ForeignKey("Team")] public string TeamId { get; set; }
        public DateOnly? ProbasionDate {  get; set; }
        public DateOnly? HireDate { get; set; }
        public DateOnly? TerminationDate {  get; set; }
        
        public Role Role { get; set; }
        public Team Team { get; set; }
        public ICollection<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
