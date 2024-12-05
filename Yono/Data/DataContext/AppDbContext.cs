using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Yono.Modules.Personnel.Models;

namespace Yono.Data.DataContext
{
    public partial class AppDbContext: DbContext
    {
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=CONGDINH88\\SQLEXPRESS;Database=Yono;User Id=sa;Password=pas123456;TrustServerCertificate=True");

    }
}
