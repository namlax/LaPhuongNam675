using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaPhuongNam675.Models;

namespace LaPhuongNam675.Data
{
    public class LaPhuongNam675Context : DbContext
    {
        public LaPhuongNam675Context (DbContextOptions<LaPhuongNam675Context> options)
            : base(options)
        {
        }

        public DbSet<LaPhuongNam675.Models.PersonLPN675> PersonLPN675 { get; set; }

        public DbSet<LaPhuongNam675.Models.LPN0675> LPN0675 { get; set; }
    }
}