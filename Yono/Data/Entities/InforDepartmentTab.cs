using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Data.Entities
{
    [Table("InforDepartments",Schema="Employees")]
    public class InforDepartmentTab
    {
        [Key]
        [MaxLength(10)]
        public string Code { get; set; }
        [Required]
        [MaxLength(50)]
        public string Department { get; set; }
    }
}
