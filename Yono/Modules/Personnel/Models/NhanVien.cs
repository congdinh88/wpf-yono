using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yono.Modules.Personnel.Models
{
    [Table("NhanViens", Schema ="NHANSU")]
    public class NhanVien
    {
        [Key]
        [MaxLength(7)]
        public string Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        [MaxLength(50)]
        public string JobPosition { get; set; }
        [MaxLength(50)]
        public string Workshop { get; set; }
        [MaxLength(10)]
        public string Tell { get; set; }
        [MaxLength(255)]
        public string Add { get; set; }

        public DateOnly Date1 { get; set; }
    }
}
