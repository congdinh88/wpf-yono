using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("EmployeeDetails", Schema ="Employee")]
    public class EmployeeDetail
    {
        [Key] public int EmployeeDetailsId { get; set; }
        public string Tell { get; set; }
        public string Address { get; set; }
        [ForeignKey("Employee")] public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
